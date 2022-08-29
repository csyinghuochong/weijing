namespace ET
{
    // 不需要返回消息
    public interface IActorMessage : IMessage
    {
    }

    public interface IActorRequest : IRequest
    {
    }

    public interface IActorResponse : IResponse
    {
    }

    public interface IDBCacheActorRequest : IActorRequest
    {
    }

    public interface IDBCacheActorResponse : IActorResponse
    {
    }

    public interface IChatActorRequest : IActorRequest
    {
    }

    public interface IChatActorResponse : IActorResponse
    {
    }

    public interface IMailActorRequest : IActorRequest
    {
    }

    public interface IMailActorResponse : IActorResponse
    {
    }

    public interface IRechargeActorRequest : IActorRequest
    {
    }

    public interface IRechargeActorResponse : IActorResponse
    {
    }

    public interface IRankActorRequest : IActorRequest
    {
    }

    public interface IRankActorResponse : IActorResponse
    {
    }

    public interface IPaiMaiListRequest : IActorRequest
    {
    }

    public interface IPaiMaiListResponse : IActorResponse
    {
    }

    public interface IActivityActorRequest : IActorRequest
    {
    }

    public interface IActivityActorResponse : IActorResponse
    {
    }

    public interface ICenterActorRequest : IActorRequest
    {
    }

    public interface ICenterActorResponse : IActorResponse
    {
    }

    public interface ITeamActorRequest : IActorRequest
    {
    }

    public interface ITeamActorResponse : IActorResponse
    {
    }

    public interface IFriendActorRequest : IActorRequest
    {
    }

    public interface IFriendActorResponse : IActorResponse
    {
    }

    public interface IUnionActorRequest : IActorRequest
    {
    }

    public interface IUnionActorResponse : IActorResponse
    {
    }
}