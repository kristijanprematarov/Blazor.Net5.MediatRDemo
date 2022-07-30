using DemoLibrary.Models;
using MediatR;
using System.Collections.Generic;

namespace DemoLibrary.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}
