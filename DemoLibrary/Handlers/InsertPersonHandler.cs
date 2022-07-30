using DemoLibrary.Commands;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using DemoLibrary.DataAccess;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
    {
        private readonly IDataAccess _data;

        public InsertPersonHandler(IDataAccess data)
        {
            _data = data;
        }

        public async Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            PersonModel result = await _data.InsertPerson(request.FirstName, request.LastName);

            return result;
        }
    }
}
