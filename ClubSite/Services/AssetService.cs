using ClubSite.Models;
using System;

namespace ClubSite.Services
{
    public interface IAssetService
    {
        Asset GetAsset(Guid guid);
    }
    public class AssetService
    {
        public Asset GetAsset(Guid guid)
        {
            return new Asset();
        }
    }
}
