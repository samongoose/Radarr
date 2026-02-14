namespace NzbDrone.Core.CustomFormats
{
    public class RemasterTitleSpecification : RegexSpecificationBase
    {
        public override int Order => 15;
        public override string ImplementationName => "Remaster Title";
        public override string InfoLink => "https://wiki.servarr.com/radarr/settings#custom-formats-2";

        protected override bool IsSatisfiedByWithoutNegate(CustomFormatInput input)
        {
            return MatchString(input.RemasterTitle);
        }
    }
}
