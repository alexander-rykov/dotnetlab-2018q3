using System.Collections.Generic;
using System.Linq;

namespace AsyncAwaitExamples
{
    public class BatchResult
    {
        private readonly List<string> _errors = new List<string>();

        public bool Success => !Errors.Any();

        public void AddError(string error)
        {
            _errors.Add(error);
        }

        public IEnumerable<string> Errors => _errors;
    }
}
