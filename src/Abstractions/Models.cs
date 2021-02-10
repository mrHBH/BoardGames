using System;
using System.Collections.Immutable;
using System.Reactive;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Stl.Fusion.Authentication;
using Stl.Serialization;

namespace BoardGames.Abstractions
{
    // API-level entities

    public enum GameStage
    {
        New = 0,
        Playing = 1,
        Ended = 0x10,
    }

    public record Game
    {
        public interface IGameCommand : ISessionCommand { }
        public interface IGameCommand<TResult> : ISessionCommand<TResult>, IGameCommand { }

        public record CreateCommand(Session Session, string EngineId) : IGameCommand<Game> {
            public CreateCommand() : this(Session.Null, "") { }
        }
        public record JoinCommand(Session Session, string Id, bool Join = true) : IGameCommand<Unit> {
            public JoinCommand() : this(Session.Null, "") { }
        }
        public record StartCommand(Session Session, string Id) : IGameCommand<Unit> {
            public StartCommand() : this(Session.Null, "") { }
        }
        public record MoveCommand(Session Session, string Id, GameMove Move) : IGameCommand<Unit> {
            public MoveCommand() : this(Session.Null, "", null!) { }
        }
        public record EditCommand(Session Session, string Id, bool IsPublic) : IGameCommand<Unit> {
            public EditCommand() : this(Session.Null, "", false) { }
        }

        public string Id { get; init; } = "";
        public string EngineId { get; init; } = "";
        public long UserId { get; init; }
        public bool IsPublic { get; init; }
        public ImmutableList<GamePlayer> Players { get; init; } = ImmutableList<GamePlayer>.Empty;
        public DateTime CreatedAt { get; init; }
        public DateTime? StartedAt { get; init; }
        public DateTime? LastMoveAt { get; init; }
        public DateTime? EndedAt { get; init; }
        public long? MaxScore { get; init; }
        public GameStage Stage { get; init; }
        public string StateMessage { get; init; } = "";
        public string StateJson { get; init; } = "";

        public virtual bool Equals(Game? other) => ReferenceEquals(this, other);
        public override int GetHashCode() => RuntimeHelpers.GetHashCode(this);
    }

    public record GamePlayer(long UserId, long Score = 0)
    {
        public GamePlayer() : this(0) { }
    }

    public record GameUser(long Id, string Name = "(unknown)")
    {
        public static GameUser None { get; } = new();

        public GameUser() : this(0, "(none)") { }
    }
}