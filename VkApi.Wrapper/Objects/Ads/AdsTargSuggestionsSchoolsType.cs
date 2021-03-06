using System.Runtime.Serialization;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// School type
    ///</summary>
    public enum AdsTargSuggestionsSchoolsType
    {
        [EnumMember(Value = "school")]
        School,
        [EnumMember(Value = "university")]
        University,
        [EnumMember(Value = "faculty")]
        Faculty,
        [EnumMember(Value = "chair")]
        Chair
    }
}