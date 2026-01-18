using FluentValidation;
using NzbDrone.Core.Annotations;
using NzbDrone.Core.Validation;

namespace NzbDrone.Core.CustomFormats
{
    public enum IsTrumpableValue
    {
        [FieldOption("False")]
        False = 0,
        [FieldOption("True")]
        True = 1
    }

    public class IsTrumpableSpecificationValidator : AbstractValidator<IsTrumpableSpecification>
    {
        public IsTrumpableSpecificationValidator()
        {
        }
    }

    public class IsTrumpableSpecification : CustomFormatSpecificationBase
    {
        private static readonly IsTrumpableSpecificationValidator Validator = new ();

        public override int Order => 16;
        public override string ImplementationName => "Is Trumpable";
        public override string InfoLink => "https://wiki.servarr.com/radarr/settings#custom-formats-2";

        [FieldDefinition(1, Label = "CustomFormatsSpecificationValue", Type = FieldType.Select, SelectOptions = typeof(IsTrumpableValue))]
        public int Value { get; set; }

        protected override bool IsSatisfiedByWithoutNegate(CustomFormatInput input)
        {
            return input.IsTrumpable == (Value == 1);
        }

        public override NzbDroneValidationResult Validate()
        {
            return new NzbDroneValidationResult(Validator.Validate(this));
        }
    }
}
