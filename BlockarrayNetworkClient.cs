/*
 * BlockarrayNetwork.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using BlockarrayNetwork.Standard.Controllers;
using BlockarrayNetwork.Standard.Http.Client;
using BlockarrayNetwork.Standard.Utilities;

namespace BlockarrayNetwork.Standard
{
    public partial class BlockarrayNetworkClient
    {

        /// <summary>
        /// Singleton access to System controller
        /// </summary>
        public SystemController System
        {
            get
            {
                return SystemController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Driver controller
        /// </summary>
        public DriverController Driver
        {
            get
            {
                return DriverController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Shipper controller
        /// </summary>
        public ShipperController Shipper
        {
            get
            {
                return ShipperController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Carrier controller
        /// </summary>
        public CarrierController Carrier
        {
            get
            {
                return CarrierController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Receiver controller
        /// </summary>
        public ReceiverController Receiver
        {
            get
            {
                return ReceiverController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DriverPassport controller
        /// </summary>
        public DriverPassportController DriverPassport
        {
            get
            {
                return DriverPassportController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to AddDriver controller
        /// </summary>
        public AddDriverController AddDriver
        {
            get
            {
                return AddDriverController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to CreateDriverPassport controller
        /// </summary>
        public CreateDriverPassportController CreateDriverPassport
        {
            get
            {
                return CreateDriverPassportController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to UpdateDriverPassport controller
        /// </summary>
        public UpdateDriverPassportController UpdateDriverPassport
        {
            get
            {
                return UpdateDriverPassportController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ChangeDriverCarrier controller
        /// </summary>
        public ChangeDriverCarrierController ChangeDriverCarrier
        {
            get
            {
                return ChangeDriverCarrierController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to RemoveDriverCarrier controller
        /// </summary>
        public RemoveDriverCarrierController RemoveDriverCarrier
        {
            get
            {
                return RemoveDriverCarrierController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DailyLogDefectsReport controller
        /// </summary>
        public DailyLogDefectsReportController DailyLogDefectsReport
        {
            get
            {
                return DailyLogDefectsReportController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DailyLog controller
        /// </summary>
        public DailyLogController DailyLog
        {
            get
            {
                return DailyLogController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DriverDailyLogTick controller
        /// </summary>
        public DriverDailyLogTickController DriverDailyLogTick
        {
            get
            {
                return DriverDailyLogTickController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to BillOfLading controller
        /// </summary>
        public BillOfLadingController BillOfLading
        {
            get
            {
                return BillOfLadingController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Detention controller
        /// </summary>
        public DetentionController Detention
        {
            get
            {
                return DetentionController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Quote controller
        /// </summary>
        public QuoteController Quote
        {
            get
            {
                return QuoteController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to Load controller
        /// </summary>
        public LoadController Load
        {
            get
            {
                return LoadController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to AssignDriverToLoad controller
        /// </summary>
        public AssignDriverToLoadController AssignDriverToLoad
        {
            get
            {
                return AssignDriverToLoadController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to OriginArrival controller
        /// </summary>
        public OriginArrivalController OriginArrival
        {
            get
            {
                return OriginArrivalController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to LoadPickup controller
        /// </summary>
        public LoadPickupController LoadPickup
        {
            get
            {
                return LoadPickupController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to DestinationArrival controller
        /// </summary>
        public DestinationArrivalController DestinationArrival
        {
            get
            {
                return DestinationArrivalController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to LoadDropOff controller
        /// </summary>
        public LoadDropOffController LoadDropOff
        {
            get
            {
                return LoadDropOffController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to ListLoad controller
        /// </summary>
        public ListLoadController ListLoad
        {
            get
            {
                return ListLoadController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to SubmitQuote controller
        /// </summary>
        public SubmitQuoteController SubmitQuote
        {
            get
            {
                return SubmitQuoteController.Instance;
            }
        }

        /// <summary>
        /// Singleton access to AcceptQuote controller
        /// </summary>
        public AcceptQuoteController AcceptQuote
        {
            get
            {
                return AcceptQuoteController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public BlockarrayNetworkClient() { }
        #endregion
    }
}