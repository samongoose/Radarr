using FluentMigrator;
using NzbDrone.Core.Datastore.Migration.Framework;

namespace NzbDrone.Core.Datastore.Migration
{
    [Migration(100_001)]
    public class add_trumpable_and_remaster_title_to_moviefiles : NzbDroneMigrationBase
    {
        protected override void MainDbUpgrade()
        {
            Alter.Table("MovieFiles").AddColumn("IsTrumpable").AsBoolean().WithDefaultValue(false);
            Alter.Table("MovieFiles").AddColumn("RemasterTitle").AsString().Nullable();
        }
    }
}
