using System;

namespace ClubSite.Models
{
    public interface IAuditable
    {
        DateTimeOffset DateCreated { get; }
        DateTimeOffset DateLastUpdated { get; }
        Member CreatedBy { get; }
        Member LastUpdatedBy { get; }
    }
}