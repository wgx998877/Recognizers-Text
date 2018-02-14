using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Microsoft.Recognizers.Text.Sequence
{
    class BaseIPExtractor : BaseSequenceExtractor
    {
        internal override ImmutableDictionary<Regex, string> Regexes { get; }
        protected sealed override string ExtractType { get; } = Constants.MODEL_IP;

        public BaseIPExtractor()
        {
            var regexes = new Dictionary<Regex, string>
            {
                {
                    new Regex(BasePhoneNumbers.BrazilPhoneNumberRegex), Constants.PHONE_NUMBER_REGEX_BRAZIL
                },
                {
                    new Regex(BasePhoneNumbers.GeneralPhoneNumberRegex), Constants.PHONE_NUMBER_REGEX_GENERAL
                }
            };
        }
    }
}
