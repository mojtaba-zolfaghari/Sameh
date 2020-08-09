using System;
using System.Collections.Generic;
using System.Text;

namespace Sameh.Entities
{
    public enum ApplicantType
    {
        City = 1,
        Municipality = 2,
        Organizatoin = 3
    }
    public enum militaryServiceStatus
    {
        EndOFMilitaryService = 1,
        PermanentExemption = 2,
        TemporaryExemption = 3,
        MedicalExemption = 4
    }
    public enum MaritalType
    {
        Single = 1,
        Married = 2,
        SingleHousehold = 3
    }
    public enum MunicipalityTransportOrganizationType
    {
        CityAndSuburbsPublicTransportOrganization = 1,
        MunicipalTransportationManagement = 2,
        MunicipalBus = 3,
        MunicipalTaxiDrivers = 4,
        MunicipalTerminal = 5,
        Other = 6
    }
    public enum IntraCityType
    {
        Freight = 1,
        Passenger = 2
    }
    public enum PassengerIntraCityServiceType
    {
        Managerial = 1,
        Passenger = 2,
        Other = 3
    }
    public enum FreightIntraCityServiceType
    {
        Managerial = 1,
        Passenger = 2,
        Other = 3
    }
    public enum PassengerIntraCityFleetType
    {
        withFleet = 1,
        WithOutFleet = 2,
        Other=3
    } 
    public enum ManagerialPassengerIntraCityServiceAreaType
    {
        Bus = 1,
        Taxi = 2,
        Agency = 3,
        InternetTaxies=4
    }
    public enum PassengerPassengerIntraCityServiceAreaServiceType
    {
        Student = 1,
        OfficesOrganizationsCompaniesFactories = 2,
    } 
    public enum OtherPassengerIntraCityServiceAreaServiceType
    {
        Exclusive = 1,
        Other = 2,
    }

}
