using System.Runtime.Serialization;

namespace ProjectMercury.Helpers
{
    public class CatFact
    { 

        [DataContract]
        public class Response
        {
            [DataMember(Name = "facts")]
            public string Fact { get; set; }

            [DataMember(Name = "success")]
            public string Success { get; set; }
        }
    }
}