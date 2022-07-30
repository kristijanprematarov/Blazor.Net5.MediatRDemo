using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
    {
        private readonly IDataAccess _data;

        public GetPersonListHandler(IDataAccess data)
        {
            _data = data;
        }

        public async Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
        {
            return await _data.GetPeople();
        }
    }
}
