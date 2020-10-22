﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.121.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.HubSpot.Domain.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;

    using global::Naos.HubSpot.Domain;
    using global::Naos.HubSpot.Domain.Model;
    using global::Naos.Protocol.Domain;

    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.Math.Recipes;

    /// <summary>
    /// The default (code generated) Dummy Factory.
    /// Derive from this class to add any overriding or custom registrations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.121.0")]
#if !NaosHubSpotSolution
    internal
#else
    public
#endif
    abstract class DefaultHubSpotDummyFactory : IDummyFactory
    {
        public DefaultHubSpotDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new AddCompanyRequest(
                                 A.Dummy<IReadOnlyCollection<PropertyModel>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new AddOrUpdateContactsRequest(
                                 A.Dummy<int?>(),
                                 A.Dummy<string>(),
                                 A.Dummy<IReadOnlyCollection<PropertyModel>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Company(
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new Contact(
                                 A.Dummy<IReadOnlyDictionary<string, string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new ContactPropertyModel(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<int?>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<bool?>(),
                                 A.Dummy<bool?>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetAllCompanyPropertiesResponse(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<int>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateAssociationRequest(
                                 A.Dummy<long>(),
                                 A.Dummy<long>(),
                                 A.Dummy<string>(),
                                 A.Dummy<int>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new PropertyModel(
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new UpdateCompanyModel(
                                 A.Dummy<long>(),
                                 A.Dummy<IReadOnlyCollection<PropertyModel>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new AddCompanyOp(
                                 A.Dummy<Company>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateCompanyPropertyOp(
                                 A.Dummy<CreateCompanyPropertyRequest>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteCompanyOp(
                                 A.Dummy<long>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteCompanyPropertyOp(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetAllCompaniesOp(
                                 A.Dummy<IReadOnlyCollection<string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetAllCompanyPropertiesOp());

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new UpdateCompaniesOp(
                                 A.Dummy<IReadOnlyCollection<Company>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new AddOrUpdateContactsOp(
                                 A.Dummy<IReadOnlyCollection<Contact>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateContactPropertyOp(
                                 A.Dummy<CreateContactPropertyRequest>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteContactPropertyOp(
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteContactOp(
                                 A.Dummy<int>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetAllContactPropertiesOp());

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new GetAllContactsOp(
                                 A.Dummy<IReadOnlyCollection<string>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new AssociateContactWithCompanyOp(
                                 A.Dummy<long>(),
                                 A.Dummy<long>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new SyncWithHubSpotOp());

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateCompanyPropertyRequest(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CreateContactPropertyRequest(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new DeleteContactResponse(
                                 A.Dummy<int>(),
                                 A.Dummy<bool>(),
                                 A.Dummy<string>()));
        }

        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}