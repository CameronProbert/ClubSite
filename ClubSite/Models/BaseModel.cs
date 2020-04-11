using System;

namespace ClubSite.Models
{
    public abstract class BaseModel
    {
        public BaseModel () {}
        public BaseModel (Member creator)
        {
            CreatedBy = creator;
            LastUpdatedBy = creator;
        }

        public int Id { get; }
        public Guid Guid { get; }

        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateLastUpdated { get; set; }
        public Member CreatedBy { get; set; }
        public Member LastUpdatedBy { get; set; }
    }
}