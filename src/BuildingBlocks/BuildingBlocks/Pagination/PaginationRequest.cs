using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks.Pagination
{
    public record PaginationRequest(int PageIndex = 0, int PageSize = 10);
}
