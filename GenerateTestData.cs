using Bogus;
using TestDataCreator.Model;

namespace TestDataCreator
{
    public static class GenerateTestData
    {
        public static IList<Application> GenerateApplicationsData (int count)
        {
            var dataFaker = new Faker<Application>()
                 .RuleFor(x => x.Id, faker => faker.IndexFaker)
                 .RuleFor(x => x.Firm, faker => faker.Company.CompanyName())
                 .RuleFor(x => x.Job, faker => faker.Person.Company.ToString())
                 .RuleFor(x => x.Decription, faker => faker.Address.City())
                 .RuleFor(x => x.ServiceName, faker => faker.PickRandom<ServiceName>())
                 .RuleFor(x => x.AgreementAccepted, faker => faker.PickRandom<bool>(new bool[2] { false, true }))
                 .RuleFor(x => x.SendDate, faker => faker.Date.Between(DateTime.Today.AddYears(-10), DateTime.Today));

                        var AccountHolders = dataFaker.Generate(100);

            return dataFaker.Generate(count);
        }
    }
}