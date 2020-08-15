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



    #region User
    public enum GenderType
    {
        Male = 1,
        Femail = 2
    }
    public enum EducationType
    {
        ReadAndWrite = 1,
        Elementary = 2,
        HighSchool = 3,
        Diploma = 4,
        Associate = 5,
        Bachelor = 6,
        Master = 7,
        Doctoral = 8,
        Proffesional = 9,
        Other = 10
    }
    public enum MilitaryServiceStatus
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
    #endregion

    #region Municipality


    #region General
    public enum IntraCityType
    {
        Freight = 1,
        Passenger = 2
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
    #endregion

    #region Passenger
    public enum PassengerIntraCityServiceType
    {
        Managerial = 1,
        Passenger = 2,
        Other = 3
    }

    public enum PassengerIntraCityFleetType
    {
        withFleet = 1,
        WithOutFleet = 2,
        Other = 3
    }

    public enum ManagerialPassengerIntraCityServiceAreaType
    {
        Bus = 1,
        Taxi = 2,
        Agency = 3,
        InternetTaxies = 4
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
    #endregion


    #region Freight
    public enum FreightIntraCityServiceType
    {
        Managerial = 1,
        Passenger = 2,
        StationServices = 3,
        Other = 4
    }

    public enum FreightIntraCityServiceAreaType
    {
        PublicLoad = 1,
        Distribution = 2,
        CarRescueVehicle = 3,
        BikeDelivery = 4,
        GarbageTruck = 5,
        HomeFurnitureTruck = 5,
        TrafficLoad = 6,
        DangerouLoad = 7,
        Other = 8

    }


    #endregion



    #endregion


}
