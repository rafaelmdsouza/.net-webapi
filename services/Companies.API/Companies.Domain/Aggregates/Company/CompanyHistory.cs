using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Companies.Domain.Aggregates.Company
{
    public class CompanyHistory
    {
        private CompanyHistory()
        {
        }

        public CompanyHistory(Guid companyId, string createdBy, string message, string? reason)
        {
            CompanyId = companyId;
            CreatedBy = createdBy;
            Message = message;
            Reason = reason;
            CreatedOn = DateTime.UtcNow;
        }
        public Guid HistoryId { get; private set; }
        public Guid CompanyId { get; private set; }
        public string CreatedBy { get; private set; }
        public string Message { get; private set; }
        public string? Reason { get; private set; }
        public DateTime CreatedOn { get; private set; }

    }
}
