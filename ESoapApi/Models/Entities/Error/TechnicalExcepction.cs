using System.Runtime.Serialization;

namespace Cl.Sura.ESoapApi.Models.Entities.Error
{ 

    [Serializable]
    internal class TechnicalExcepction : Exception
    {
        public TechnicalExcepction()
        {
        }

        public TechnicalExcepction(string? message) : base(message)
        {
        }

        public TechnicalExcepction(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected TechnicalExcepction(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}