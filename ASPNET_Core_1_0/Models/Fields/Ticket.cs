using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MatterCentral.Models
{

    public class TicketType
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class TicketStatus
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class TicketApprovalStatus
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class TicketProcessStatus
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    
    public class Ticket
    {
        public int Id { get; set; }
        public bool QuotaOverride { get; set; }
        public string LoadTicketNumber { get; set; }
        public string SupplierTicketNumber { get; set; }
        public string ContainerNumber { get; set; }

        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public DateTime CreationDate { get; set; }
        public double Gross { get; set; }
        public double Tare { get; set; }
        public double Net { get; set; }
        public double ConvertedNet { get; set; }
        // extra: AlternateQuantity .... examples "USD, EUR, TN, LB" (weight units mixed with currency?)
        // extra: AlternateConvertedNet
        
        public int? AuthorizationId { get; set; }
        public Authorization Authorization { get; set; }

        public int? AccountId { get; set; }
        public Account Account { get; set; }

        public int? DriverId { get; set; }
        public Driver Driver { get; set; }

        public int? ScalerId { get; set; }
        public Scaler Scaler { get; set; }

        public int? TransportationId { get; set; }
        public Transportation Transportation { get; set; }

        public int? CommodityId { get; set; }
        public Commodity Commodity { get; set; }

        public int? ProducerId { get; set; }
        public Organization Producer { get; set; }

        public int? OriginationId { get; set; }
        public Location Origination { get; set; }

        public int? DestinationId { get; set; }
        public Location Destination { get; set; }

        public int? OffloadPointId { get; set; }
        public OffloadPoint OffloadPoint { get; set; }

        public int? TractId { get; set; }
        public Tract Tract { get; set; }

        public int? WeightUnitTypeId { get; set; }
        public WeightUnitType WeightUnitType { get; set; }

        public int? TypeId { get; set; }
        public TicketType Type { get; set; }

        public int? StatusId { get; set; }
        public TicketStatus Status { get; set; }

        public int? ApprovalStatusId { get; set; }
        public TicketApprovalStatus ApprovalStatus { get; set; }

        public int? ProcessStatusId { get; set; }
        public TicketProcessStatus ProcessStatus { get; set; }
    }
}
