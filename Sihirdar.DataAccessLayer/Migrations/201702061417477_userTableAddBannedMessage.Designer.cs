// <auto-generated />

using System.CodeDom.Compiler;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

namespace Sihirdar.DataAccessLayer.Migrations
{
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class userTableAddBannedMessage : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(userTableAddBannedMessage));
        
        string IMigrationMetadata.Id
        {
            get { return "201702061417477_userTableAddBannedMessage"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
