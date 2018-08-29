using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Collections;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Reflection;
using System.Diagnostics;
using System.Globalization;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace BusinessLayer.ClassFiles
{
    public class Constants
    {

        #region Settlement

        public static string DeleteSettlement = "[USP_DeleteSettlementType]";
        public static string GetSettlement = "[USP_GetSettlementType]";
        public static string SaveSettlement = "[USP_SaveSettlementType]";
        public static string GetSalesOffice = "[USP_GetSalesOffice]";
        public static string GetSalesPerson = "[USP_GetSalesPerson]";
        public static string SaveSalesOffice = "[USP_SaveSalesOffice]";
        public static string SaveSalesPerson = "[USP_SaveSalesPerson]";
        public static string DeleteSalesOffice = "[USP_DeleteSalesOffice]";
        public static string DeleteSalesPerson = "[USP_DeleteSalesPerson]";


        #endregion

        #region Roles

        public static string GetRoleDetails = "USP_GetRoleDetails";
        public static string SaveRole = "USP_SaveRole";
        public static string DeleteRole = "USP_DeleteRole";

        #endregion

        #region Room

        public static string GetRoomType = "[USP_GetRoomTypes]";
        public static string SaveRoomType = "[USP_SaveRoomTypes]";
        public static string DeleteRoomType = "[USP_DeleteRoomTypes]";
        public static string GetRoom = "[USP_GetRoom]";
        public static string DeleteRoom = "[USP_DeleteRoom]";
        public static string SaveRoom = "[USP_SaveRoom]";
        public static string GetRoomFeature = "[USP_GetRoomFeature]";
        public static string SaveRoomFeature = "[USP_SaveRoomFeature]";
        public static string DeleteRoomFeature = "[USP_DeleteRoomFeature]";
        public static string GetRoomBlock = "[USP_GetRoomBlock]";
        public static string SaveRoomBlock = "[USP_SaveRoomBlock]";
        public static string DeleteRoomBlock = "[USP_DeleteRoomBlock]";
        public static string GetHotelPosition = "[USP_HotelPosition]";
        public static string GetHotelPositionExtended = "[USP_HotelPositionExtended]";
        public static string GetHotelCompanyPosition = "[USP_HotelCompanyPosition]";
        public static string GetCompanyPosition = "[USP_CompanyPosition]";

        public static string GetRoomNumber = "[USP_GetRoomNo]";
        public static string GetRoomGuest = "[USP_GetRoomGuest]";

        #endregion

        #region Payment

        public static string SavePaidOut = "[USP_SavePaidOut]";
        public static string GetPaidOut = "[USP_GetPaidOut]";
        public static string DeletePaidOut = "[USP_DeletePaidOut]";
        public static string GetPayMode = "[USP_GetPayMode]";
        public static string SavePayMode = "[USP_SavePayMode]";
        public static string DeletePayMode = "[USP_DeletePayMode]";

        #endregion

        #region Country

        public static string GetCountry = "[USP_GetNationality]";
        public static string SaveCountry = "[USP_SaveNationality]";
        public static string DeleteCountry = "[USP_DeleteNationality]";


        #endregion

        #region Meal

        public static string DeleteMeal = "[USP_DeleteMealPlan]";
        public static string SaveMeal = "[USP_SaveMealPlan]";
        public static string GetMeal = "[USP_GetMealPlan]";


        #endregion

        #region Market

        public static string SaveMarketSegment = "[USP_SaveMarketSegment]";
        public static string DeleteMarketSegment = "[USP_DeleteMarketSegment]";
        public static string GetMarketSegment = "[USP_GetMarketSegment]";


        #endregion

        #region Guest

        public static string GetGuestCategory = "[USP_GetGuestCategory]";
        public static string SaveGuestCategory = "[USP_SaveGuestCategory]";
        public static string DeleteGuestCategory = "[USP_DeleteGuestCategory]";

        public static string GetGuestStatus = "[USP_GetGuestStatus]";
        public static string DeleteGuestStatus = "[USP_DeleteGuestStatus]";
        public static string SaveGuestStatus = "[USP_SaveGuestStatus]";

        #endregion

        #region Group

        public static string GetGroup = "[USP_GetGroup]";
        public static string SaveGroup = "[USP_SaveGroupMaster]";
        public static string DeleteGroup = "[USP_DeleteGroup]";



        #endregion

        #region Property
        public static string GetVoucherProperty = "[USP_GetPropertyVoucher]";
        public static string GetProperty = "[USP_GetProperty]";
        public static string SaveProperty = "[USP_SaveProperty]";
        public static string DeleteProperty = "[USP_DeleteProperty]";

        #endregion

        #region BillInstructions

        public static string SaveVoucherSettings = "[USP_SaveVoucherSettings]";
        public static string GetVoucherDetails = "[USP_GetVoucherDetails]";
        public static string GetBillInstructions = "[USP_GetBillingInstruction]";
        public static string SaveBillInstructions = "[USP_SaveBillingInstruction]";
        public static string DeleteBillInstructions = "[USP_DeleteBillingInstruction]";
        public static string GetBillInstructionsRevenue = "[USP_GetBillingInstructionRevenue]";
        public static string SaveBillInstructionsRevenue = "[USP_SaveBillingInstructionRevenue]";
        public static string DeleteBillInstructionsRevenue = "[USP_DeleteBillingInstructionRevenue]";

        #endregion

        #region BusinessSources

        public static string GetBusinessSources = "[USP_GetBusinessSource]";
        public static string SaveBusinessSources = "[USP_SaveBusinessSource]";
        public static string DeleteBusinessSources = "[USP_DeleteBusinessSource]";

        #endregion

        #region Company

        public static string GetCompanyTypes = "[USP_GetCompanyTypes]";
        public static string SaveCompanyTypes = "[USP_SaveCompanyTypes]";
        public static string DeleteCompanyTypes = "[USP_DeleteCompanyTypes]";
        public static string GetCompany = "[USP_GetCompany]";
        public static string SaveCompany = "[USP_SaveCompany]";
        public static string DeleteCompany = "[USP_DeleteCompany]";
        public static string SearchCompany = "[USP_SearchCompany]";
        public static string GetCompanyPayment = "[USP_GetCompanyPayment]";

        #endregion

        #region ControlTable

        public static string GetControlTable = "[USP_GetControlTable]";
        public static string SaveControlTable = "[USP_SaveControlTable]";
        public static string DeleteControlTable = "[USP_DeleteControlTable]";

        #endregion

        #region CreditCard

        public static string GetCreditCard = "[USP_GetCreditCard]";
        public static string SaveCreditCard = "[USP_SaveCreditCard]";
        public static string DeleteCreditCard = "[USP_DeleteCreditCard]";

        #endregion

        #region Currency

        public static string GetCurrency = "[USP_GetCurrency]";
        public static string SaveCurrency = "[USP_SaveCurrency]";
        public static string DeleteCurrency = "[USP_DeleteCurrency]";

        #endregion

        #region Department

        public static string GetDepartment = "[USP_GetDepartment]";
        public static string SaveDepartment = "[USP_SaveDepartment]";
        public static string DeleteDepartment = "[USP_DeleteDepartment]";

        #endregion

        #region Forex

        public static string GetForex = "[USP_GetForex]";
        public static string SaveForex = "[USP_SaveForex]";
        public static string DeleteForex = "[USP_DeleteForex]";

        #endregion

        #region Revenue

        public static string GetRevenue = "[USP_GetRevenue]";
        public static string SaveRevenue = "[USP_SaveRevenue]";
        public static string DeleteRevenue = "[USP_DeleteRevenue]";

        #endregion

        #region Rate

        public static string GetRate = "[USP_GetRate]";
        public static string SaveRate = "[USP_SaveRate]";
        public static string DeleteRate = "[USP_DeleteRate]";

        #endregion

        #region Tax
        public static string GetTaxCode = "[USP_GetTaxCodes]";
        public static string SaveTaxCode = "[USP_SaveTaxCodes]";
        public static string DeleteTaxCode = "[USP_DeleteTaxCodes]";
        public static string GetTaxSlab = "[USP_GetTaxSlab]";
        public static string SaveTaxSlab = "[USP_SaveTaxSlab]";
        public static string DeleteTaxSlab = "[USP_DeleteTaxSlab]";
        public static string GetTaxStructure = "[USP_GetTaxStructure]";
        public static string SaveTaxStructure = "[USP_SaveTaxStructure]";
        public static string DeleteTaxStructure = "[USP_DeleteTaxStructure]";
        public static string GetTaxTypes = "[USP_GetTaxTypes]";

        #endregion

        #region Default

        public static string GetDefault = "USP_GetDefault";
        public static string SaveDefault = "USP_SaveDefault";
        public static string DeleteDefault = "USP_DeleteDefault";

        #endregion

        #region Login

        public static string RegisterLogAttempt = "[Usp_RegisterUserSessionInfo]";
        public static string LogActivityReport = "[USP_GetUserLogActivity]";

        #endregion

        public static string GetMenus = "USP_GetMenu";
        public static string GetBooking = "[USP_SearchReservation]";
        public static string SaveGuestDetails = "[Usp_SaveGuestDetails]";
        public static string GetTree = "[Usp_FillTree]";
        public static string SaveGuestBookingRate = "[USP_SaveGuestBookingRate]";
        public static string CheckReservation = "[USP_CheckReservation]";
        public static string GetRateType = "[USP_GetRateType]";
        public static string GetRoomCount = "[USP_GetRoomCount]";
        public static string GetRoomTypeDropDown;
        public static string GetCurrencyType = "[USP_GetCurrency]";
        public static string SaveMachineData = "[USP_SaveMachineData]";
        public static string GetServerFolderInfo = "[USP_CheckSharedFolder]";
        public static string SaveBookingDetails = "[Usp_makereservation]";
        public static string GetGuestBookingRate = "[USP_GetGuestBookingRate]";
        public static string GetReservationData = "[USP_GetReservation]";
        public static string GetStatus = "[USP_GetStatus]";
        public static string GetPickUps = "[USP_GetPickup]";
        public static string GetHistory = "[USP_GetHistory]";

        #region reports

        public static string GetExpectedArrivalReport = "[USP_GetExpectedArrivalReport]";
        public static string GetTodaysCheckIns = "[USP_GetTodaysCheckins]";
        
        public static string UndoCheckIn = "[USP_UndoCheckin]";
        public static string SaveCheckInDetails = "[USP_SaveCheckInDetails]";

        public static string SearchNationality = "[USP_SearchNationality]";
        public static string GetMaxRegNo = "[USP_GetMaxRegNo]";
        public static string GetMaxResNo = "[USP_GetMaxResNo]";
        public static string GetReservationDataBySrNo = "[USP_GetReservationBySubSr]";
        public static string GuestCheckInDetails = "";
        public static string GetOccupiedRoomDetails = "[USP_GetOccupiedRoomDetails]";
        public static string GetAssignedRoom = "[USP_AssignRoom]";
        public static string GetHotelPositionGraph = "[USP_HotelPositionGraph]";
        public static string GetHotelStatus = "[USP_HotelStatus]";
        public static string GetHotelRoomStatus = "[USP_HotelRoomStatus]";

        #endregion


        public static string GetRoomBlockedType = "[USP_GetRoomBlockedType]";
        public static string GetReason = "[USP_GetReason]";
        public static string GetRoomBlocked = "[USP_GetRoomBlocked]";
        public static string SaveRoomBlockedTable = "[USP_SaveRoomBlockedTable]";
        public static string SaveReason = "[USP_SaveReason]";
        public static string GetUsersDetails = "[USP_GetUsersDetails]";
        public static string SaveUserDetails = "[USP_SaveUserDetails]";
        public static string GetCalType = "[USP_GetCalType]";
        public static string GetOnTax = "[USP_GetOnTax]";
        public static string AssignRoom = "[USP_AssignGuestRoomNo]";
        public static string SavePickUp = "[USP_SavePickup]";
        public static string SaveDropup = "[USP_SaveDropup]";
        public static string GetDropup = "[USP_GetDropup]";
        public static string RevenueType = "[USP_GetRevenueType]";
        public static string RevenueClassifications = "[USP_GetRevenueClassifications]";

        public static string SaveEmails = "[USP_SaveEmailerSettings]";
        public static string ChangePassword = "[USP_ChangeUserPassword]";

        public static string AssignGuestRoom = "[USP_AssignGuestRoom]";

        public static string RoomPaxCount = "[USP_GetRoomPaxCount]";

        public static string GetPaxType = "[USP_GetPaxType]";

        public static string NoShow = "[USP_NoShow]";

        public static string GetGuestDetails = "[USP_GetGuestDetails]";

        public static string NonCheckedInReservation = "[USP_SearchNonCheckedInReservation]";

        public static string GetRoomGuestsDetails = "[USP_GetRoomGuestsDetails]";

        public static string GetAssignedRoomGuests = "[USP_BindAssignedGuests]";

        public static string GetAvailableRooms = "[USP_GetAvailableRooms]";

        public static string GetcheckInGuests = "[USP_SearchCheckInGuests]";

        public static string CopyReservation = "[USP_SearchCopyReservation]";

        public static string GetAccountingDate = "[USP_GetAccountingDate]";
        public static string GetRevenueCode = "[USP_GetRevenueCode]";
        public static string GetTaxCodeAndAmount = "[USP_GetTaxCodeAndAmount]";
        public static string CancelReservation = "[USP_CancelReservation]";
        public static string CancelReinstate = "[USP_SearchCancelReinstate]";
        public static string NoShowReinstate = "[USP_SearchNoShowReinstate]";
        public static string CheckIfRoomTypeIsFull = "[USP_IsThisRoomTypeFull]";

        public static string SavePostCharges = "[USP_SavePostCharges]";
        public static string GetAllCheckedInGuests = "[USP_GetAllCheckedInGuests]";
        public static string GetAllCheckedInGuest = "[USP_GetAllCheckedInGuest]";

        public static string GetBookingReportByBookingID = "[USP_GetBookingsInfoByBookingID]";

        public static string GetCheckedInGuest = "[USP_GetAllGuestCheckedIn]";
        public static string GetMaxReciptNo = "[USP_GetMaxReceiptNo]";
        public static string SavePostMiscSales = "[USP_SavePostMiscSales]";
        public static string SavePostReceiptForGuests = "[USP_SavePostReceiptForGuests]";
        public static string GetAvailableRoom = "";
        public static string GetInclusiveExclusiveTax = "[USP_GetInclusiveExclusiveTax]";
        public static string GetTaxStructureRowCount = "[USP_GetTaxStructureRowCount]";
        public static string SavePostTaxDetails = "[USP_SavePostTaxDetails]";
        public static string SaveMiscPostTaxDetails = "[USP_SaveMiscPostTaxDetails]";
        public static string GetGuestLedger = "[USP_GetGuestLedger]";
        public static string GetRoomNumberByFloorAndType = "[USP_GetRoomNoByFloorAndType]";
        public static string GetAllRoomStatus = "[USP_GetAllRoomStatus]";

        public static string GetBlock = "[USP_GetBlock]";

        public static string SaveBlock = "[USP_SaveBlock]";

        public static string GetFloor = "[USP_GetFloor]";

        public static string SaveFloor = "[USP_SaveFloor]";
        public static string GetFloorForBlock = "[USP_GetFloorForBlock]";
        public static string GetReservationDataByRoomNo = "[USP_GetReservationDetailsByRoomNo]";
        public static string GetOccupiedRooms = "[USP_GetOccupiedRooms]";
        public static string GetGuestNameByRoom = "[USP_GetGuestNameByRoom]";
        public static string AddWakeUpCall = "[USP_SaveWakeUpCall]";
        public static string SearchWakeupCalls = "[USP_GetWakeupCallsByRoomAndCallType]";
        public static string CancelOrActivateWakeupCall = "[USP_CancelOrActivateWakeUpCall]";
        public static string SearchWakeupCallsByDate = "[USP_GetWakeupCallsByDate]";
        public static string MarkWakeUpCallAsDone = "[USP_MarkWakeUpCallAsDone]";
        public static string GetSplInstr = "[USP_GetSplIns]";
        public static string CheckInCheckOutStats = "[USP_GetDashboardCheckinCheckOutData]";
        public static string TodaysCheckouts = "[USP_GetTodaysCheckOuts]";
        public static string GetAllRoomsForLinking = "[USP_GetRoomGuestsDetailsForLinking]";
        public static string SavePaidOutRefund = "[USP_SavePaidoutRefund]";
        public static string LinkUnlinkRooms = "[USP_LinkUnlinkRooms]";

        public static string GetAllGuestOccupyingThatRoom = "[USP_GetCheckedInGuestInRoom]";

        public static string GetRoomRate = "[USP_GetRoomPostingWithoutTax]";

        public static string GetRoomRateExclusiveTax = "[USP_GetRoomPosting]";

        public static string SaveRoomRate = "[USP_SavePostingRate]";

        public static string BindOccpdRooms = "[USP_GetPostingOccupiedRooms]";

        public static string GetAllRoomPostingRate = "[USP_GetAllRoomPostingWithoutTax]";

        public static string GetAllRoomPostingRateExclusiveTax = "[USP_GetAllRoomPosting]";
        // public static string GetAllRoomPostingRateExclusiveTax = "[USP_GetAllRoomPosting]";

        public static string ChangeRoom = "[USP_ChangeRoomNo]";

        public static string InHouseGuests = "[USP_SearchInHouseGuests]";

        public static string GroupAssignRoom = "[USP_GroupAssignRoomNo]";

        public static string GetCount = "[USP_CountPaxRoom]";

        public static string SaveAllRoomPosting = "[USP_SaveAllPostingRate]";

        public static string GetTaxStructureCode = "[USP_GetTaxStructureCode]";

        public static string GetCheckOutData = "[USP_GetOccupiedRoomsData]";

        public static string GetTransactions = "[USP_GetRoomsTransaction]";

        public static string CheckOutGuest = "[USP_CheckOut]";

        public static string GetMaterialisedReport = "[USP_MaterialisedReport]";

        public static string GetOccupancyForcast = "[USP_GetOccupancyForcast]";

        public static string GetMealPlanForMaster = "[USP_GetMealPlanForMaster]";

        public static string GetRoomReserved = "[USP_GetRoomsReserved]";

        public static string GetDirtyRoomsByFloorAndBlock = "[USP_GetDirtyRoomsByFloorAndBlock]";

        public static string MarkRoomForCleaning = "[USP_MarkRoomForCleaning]";

        public static string MarkRoomForInspection = "[USP_MarkRoomForInspection]";

        public static string GetHouseKeepingTasktList = "[USP_GetHouseKeepingTaskList]";

        public static string GetComputedDiscountForRate = "[USP_GetComputedDiscountForRate]";

        public static string GetRateForMealCodeNRateType = "[USP_GetRateForMealcodeNRatetype]";

        public static string GetIndRoomRate = "[USP_GetIndTaxRoomPosting]";

        public static string SetAccountingDate = "[USP_SetAccountingDate]";

        public static string GetReservedGuestData = "[USP_GetReservedGuestData]";

        public static string GetChangeGuestData = "[USP_GetChangeGuestData]";

        public static string GetRoomPostingforToday = "[USP_GetRoomPostingforToday]";

        public static string GetAmendRate = "[USP_GetAmendRate]";

        public static string SaveAmendRateDetails = "[USP_SaveAmendRateDetails]";

        public static string AssignReservedGuestsRoomNo = "[USP_AssignReservedGuestRoomNo]";

        public static string GetModifiedRoomRate = "[USP_GetModifiedTaxRoomPosting]";

        public static string ModifyPostingRate = "[USP_ModifyTransactionsWithoutTax]";

        public static string DeleteTransaction = "[USP_DeleteTransactions]";

        public static string SearchGetAllCheckedInGuests = "[USP_SearchGetAllCheckedInGuests]";

        public static string GetMasters = "[USP_GetMasters]";

        public static string SearchMasters = "[USP_SearchMasters]";

        public static string NiteAudit = "[USP_NiteAudit]";

        public static string GetAllReservations = "[USP_GetAllReservations]";

        public static string GetAllReservationsForNoShow = "[USP_GetReservationsForNoShow]";

        public static string GetAllWalkins = "[USP_GetAllWalkins]";

        public static string SaveAdvanceForReservation = "[USP_SaveAdvanceForReservation]";

        public static string GetSettlementBillWiseReport = "[USP_GetBillReportBySettlementMode]";

        public static string GetAmendRateLog = "[USP_GetAmendRateLog]";

        public static string SaveBill = "[USP_SaveBill]";

        public static string GetBill = "[USP_GetBill]";

        public static string GetBillTransaction = "[USP_GetBillTransaction]";

        public static string SaveBillTransaction = "[USP_SaveBillTransaction]";

        public static string GetHelp = "[USP_GetHelp]";

        public static string SavePayment = "[USP_SavePayment]";

        public static string CreateGuestLedger = "[USP_CreateGuestLedger]";

        public static string GuestLedgerLoad = "[USP_GetGuestLedgers]";

        public static string GetReport = "[USP_GetAllReports]";

        public static string GetGuestLedgerReport = "[USP_GetGuestLedgerReport]";

        public static string SaveSeq = "[USP_SaveBillSeq]";

        public static string SaveSpecialInstructions = "[USP_SaveSpecialInstructions]";

        public static string GenerateBill = "[USP_GenerateBill]";

        public static string CheckNiteAudit = "[USP_CheckNightAudit]";

        public static string GetAccDate = "[USP_GetAccDate]";

        public static string SearchChangeRoomNo = "SearchChangeRoomNo";

        public static string GetAndSetRoleNameAndUserName = "[USP_GetAndSetRoleNameAndUserName]";

        public static string GetAllDirtyRooms = "[USP_GetAllDirtyRooms]";

        public static string GetRevCodeForDiscBasedOnRoomNo = "[USP_GetRevenueCodeForDiscountBasedOnRoomNo]";

        public static string SavePostMiscSalesPaymentMode = "[USP_SavePostMiscSalesPaymentMode]";

        public static string GetPermissionDeteails = "[USP_GetPermission]";

        public static string SavePermission = "[USP_SavePermission]";

        public static string SaveAllBillTransaction = "[USP_SaveAllPayment]";

        public static string CheckAccess = "[USP_CheckAccess]";

        public static string GetSalesReport = "[USP_GetSalesReport]";

        public static string GetMaxAmountForDiscount = "[USP_GetMaxAmountForDiscount]";

        public static string GetRooms = "[USP_GetRoomsInReservation]";

        public static string ShiftPax = "[USP_ChangeRoomForPax]";

        public static string ShiftPaxNewRoom = "[USP_ChangeNewRoomForPax]";

        public static string ResetDatabase = "[USP_CleanAndResetDB]";

        public static string GetTransactionsTillDate = "[USP_GetRoomTransactionUntilToday]";

        public static string GetDatabaseName = "[USP_GetDatabaseName]";

        public static string GenerateComboBill = "[USP_GenerateComboBill]";

        public static string ChangeRoomTransactions = "[USP_GetBillChangeRoom]";

        public static string SaveAdvanceForWalkins = "[USP_SaveAdvanceForWalkins]";

        public static string GetRoomNumberByFloorAndTypeDynamic = "[USP_RoomNumberByFloorAndTypeDynamic]";

        public static string CheckAccessForMainMenuModules = "[USP_CheckAccessForMainMenuModules]";

        public static string CheckAndBindAMDPermissions = "[USP_CheckAMDPermissions]";

        public static string GetRoomsToBeCleaned = "[USP_GetRoomsToBeCleanedToday]";

        public static string MarkRoomForDailyCleaning = "[USP_MarkRoomForDailyCleaning]";
        public static string GetResDataByRoomNo = "[USP_GetResDetailsByRoomNo]";

        public static string GetBillData = "[USP_GetBillTransactionForReport]";

        public static string GetTransactionsByRoomNo = "[USP_GetRoomsTransactionByRoomNo]";
        public static string GetTransactionsByRoomNoUPDATED = "[USP_GetRoomsTransactionByRoomNoUPDATED]";

        public static string GetMISreport = "[USP_GetMISniteReport]";
        public static string GetPickupsForTomorrow = "[USP_GetPickupsForTomorrow]";
        public static string SearchGuest = "[USP_SearchGuestDetailsInAllTables]";
        public static string IndividualTransactions = "[USP_GetIndvBillTrans]";
        public static string BillDetails = "[USP_GetBillDetails]";
        public static string AreAllGuestsAssigned = "[USP_AreAllGuestsAssigned]";
        public static string GetAllUnassignedGuestsDetails = "[USP_GetAllUnassingedGuestsDetails]";
        public static string GetSubSrbyRegNo = "[USP_GetSubSrByRegNo]";


        public static string GetTaxAmounts = "[USP_GetTaxAmountsForBill]";
        public static string GetTaxAmountsUPDATED = "[USP_GetTaxAmountsForBillUPDATED]";

        public static string GetRateForMealCodeNRateTypeAndCategory = "[USP_GetRateForMealcodeNRatetypeAndRoomCategory]";
        public static string CheckOutRoom = "[USP_CheckOutRoom]";
        public static string GetAndSaveAllRoomsPostingRates = "[USP_FinalPosting_test]";
        public static string GetTodaysStatistics = "[USP_GetTodaysStatistics]";
        public static string GetHotelStatistics = "[USP_GetHotelStatisticsByDate]";
        public static string ComputeIncExcRate = "[USP_CalculateExclusiveRate]";
        public static string GetAllCompanyReports = "[USP_GetCompanyBillReport]";
        public static string CheckOverstayingGuest = "[USP_IsRoomOccupied]";
        public static string AbortCheckinguest = "[USP_AbortCheckin]";
        public static string GetAllRoomsUnderBookingID = "[USP_GetNoOfRoomsUnderBookingID]";
        public static string SaveNewCheckoutDate = "[USP_ExtendStay]";
        public static string GetAccountBalance = "[USP_GetAccountBalance]";
        public static string GetBookingInfo = "[USP_GetBookingInfoByRoomNo]";
        public static string GetPreAssignedRooms = "[USP_GetAllPreAssign]";
        public static string CancelPreAssignedRoom = "[USP_CancelPreAssign]";
        public static string ReleaseRecentAssignedRoom = "[USP_ReleaseRecentAssignedRoom]";
        public static string GetRoomsForRelease = "[USP_GetRoomsForRelease]";
        public static string GetBillOnHoldBills = "[USP_GetBillsOnHold]";

        public static string GetRoomStatus = "[USP_GetOccupiedRoomsForHousekeeping]";
        // public static  string
        public static string MarkRoomAsCleaned = "[USP_MarkRoomAsCleanedForHouseKeeping]";
        public static string SaveCompanyPayment = "[USP_SaveCompanyPayment]";
        public static string SavePaymentFromCompany = "[USP_SaveAmountFromCompany]";
        public static string GetCompanyBillAndReceipts = "[USP_GetCompanyReceiptsandBillNo]";
        public static string CompletePaymentFromCompanyReceipt = "[USP_CompleteCompanyBillPayment]";
        public static string GetCompanyReceiptBalance = "[USP_GetReceiptBillInformation]";
        public static string GetBillFromDate = "[USP_GetBillOnDate]";
        public static string GetCompanyBillTransactionByReceipts = "[USP_GetCompanyBillPaymentTransaction]";
        public static string GetCheckoutDateForRoom = "[USP_GetCheckoutDateForRoom]";
        public static string GetReceiptByReceiptNo = "USP_GetReceiptByReceiptNumber";
        public static string GetMISReportByDate = "[USP_GetMisReportByDate]";
        public static string ModifyGuestDetails = "[USP_EditGuestDetails]";
        public static string GetGuestDataForModification = "[USP_GetCheckinGuestDetailsToModifyDetails]";
        public static string GetRecentBillsOnHold = "[USP_GetBillOnHoldReport]";
        public static string GetBillAgeingReport = "[USP_GenerateBillAgeingReport]";
        public static string CheckBillIfCancelled = "[USP_CheckIfBillIsCancelled]";
        public static string GetTodaysCheckoutRoomsForToday = "[USP_GetTodaysCheckoutedOutRooms]";
        public static string CancelCheckout = "[USP_UndoCheckOut]";
        public static string CancelPostingCharges = "[USP_GetPostingOnRoom]";
        public static string DeletePostedChargesOnRoom = "[USP_DeleteChargesPostedOnRoom]";
        public static string GetCancelledChargesLog = "[USP_CancelledChargesLog]";
        public static string DiscountReport = "[USP_DiscountOnBillReport]";
        public static string GetBillStatuses = "[USP_CheckBillStatus]";

        #region  GetTransactionCharges

        public static string GetTransactionDetailsForModify = "[USP_GetTransactionDetailsforModify]";

        #endregion

        public static string SaveShareFolderInfo = "[USP_ShareFolderInfo]";
        public static string GetReservationWalkingNo = "[USP_GetReservationWalkinNo]";

        public static string CheckIfDummyValuesExistsinCheckinGuestdetails = "[USP_CheckIfDummyValuesExistsinCheckinGuestdetails]";

        public static string UpdateGuestDetails = "[USP_UpdateGuestDetails]";
        public static string SplitBill = "[USP_GetRoomsTransactionForSplitting]";
        public static string GenerateSplitedBill = "[USP_GenerateSplitBill]";
        public static string GetCompanyReservations = "[USP_GetCompanyReservationReport]";
        public static string GetBusinessReportByType = "[USP_GetBusinessReportByTypeFinal]";

        public static string GetClosingBalances = "[USP_GetCompanyClosingBalance]";

        public static string GetBillDetailsForCompanyInvoice = "[USP_GetBillDetailsForCompanyInvoice]";

        public static string DisplayTaxStatus = "[USP_CheckTaxDisplayStatus]";

        public static string SaveAllowance = "[USP_SaveAllowances]";

        public static string GetRoomRateForDiscount = "[USP_GetRoomRatesForDiscount]";

        public static string CheckAccessRightsForUser = "[USP_CheckPermissionLevel]";

        public static string CheckIfFeatureIsEnabled = "[USP_CheckExtraFeatureStatus]";

        public static string DeleteUserUsers = "[USP_DeleteUserDetails]";
        public static string GetCheckInCheckOutForTheDay = "[USP_GetCheckInOutCheckoutReport]";

        public static string GetAllClientEmails = "[USP_GetEmailClients]";

        public static string GetPositionClientEmails = "[USP_GetEmailClientsForPosition]";

        public static string CheckLicence = "[USP_CheckLicence]";


        public static string GetAndSaveRoomsPostingRatesSingleRoom = "[USP_IndividualRoomPosting]";

        public static string ClearRoomPostingForToday = "[USP_ClearTodaysRoomPostingForSelectedRoom]";

        public static string SaveDirectBooking = "[USP_SaveDirectBookings]";

        public static string GetBookingsReport = "[USP_GetBookingsReport]";

        public static string SaveAccountAdjustables = "[USP_SaveAccountsAdjustables]";
        public static string GetTransactionDetailsForAdjustableEntr = "[USP_GetTransactionDetailsForAdjustableEntry]";

        public static string IndividualTransactionsForAccountsPrint = "[USP_GetIndvBillTransactionForAccounts]";

        public static string IndividualTransactionForInvoicePrint = "[USP_GetTransactionDetailsForPrintingInvoice]";

        public static string GetInvoicePrintDetails = "[USP_GetInvoiceDetailsForReceiptPrint]";

        public static string DeleteAdjustables = "[USP_DeleteAdjustablesOnBill]";

        public static string GetBookingID = "[USP_GetBookingID]";

        #region SetUp Box Master
        public static string GetTVBlock = "[USP_GetSetupBoxBlock]";

        public static string GetTVRechargeStatus = "[USP_GetRoomStatusForTVRecharge]";

        public static string SaveTVBlock = "[USP_SaveTVBlock]";

        public static string SaveTVBlockRecharge = "[USP_SaveTVBlockRecharge]";
        public static string AssignRoomToBlock = "[USP_AssignRoomToTVRechargeBlock]";

        public static string SaveRechargeBlock = "[USP_SaveRechargeForBlock]";

        public static string GetAllBlockRecharges = "[USP_GetAllRecharges]";

        public static string RemoveRoomFromBlock = "[USP_RemoveRoomFromTVBlock]";

        #endregion

        #region HouseKeeping
        public static string GetHouseKeepingStaff = "[USP_GetAllStaff]";
        public static string SaveRoomForHousekeeping = "[USP_SaveHouseKeepingDuty]";
        public static string GetHouseKeepingStatus = "[USP_GetAssignedHouseKeepingStatus]";
        public static string GetHouseKeepingStatusForToolTip = "[USP_GetHouseKeepingStatusForToolTip]";
        public static string GetDailyCleaningCounters = "[USP_GetHouseKeepingDailyNotificationBar]";

        public static string SaveNewHouseKeepingStaff = "[USP_SaveHouseKeepingStaff]";
        public static string DeleteHouseKeepingStaff = "[USP_DeleteHouseKeepingStaff]";

        public static string GetHouseKeepingLogFile = "[USP_GetHouseKeepingTaskLog]";
        public static string ReportFoundItem = "[USP_ReportFoundItem]";

        #endregion


        #region Guest History

        public static string GetGuestHistoryLogs = "[USP_GetGuestHistoryDetails]";

        public static string SaveNewUserHistory = "[USP_SaveGuestHistory]";

        public static string SearchGuestHistoryWithElement = "[USP_SearchHistoryGuest]";

        public static string AssignRoomForGuestsInHistoryTable = "[USP_AssignRoomToGuestInHistoryTable]";

        public static string GetGuestInfoUsingGuestID = "[USP_GetUserInfoUsingGuestID]";

        public static string RegistrationNumberForhistoryGuet = "[Usp_AssignRegistrationNoBillToGuestInHistoryTable]";

        public static string GetHistoryGuestDetails = "[USP_GetHistoryGuestInformation]";

        public static string SaveGuestRemarks = "[USP_SaveRemarksAboutGuest]";

        #endregion

        public static string GetTransactionLogRep = "[USP_GetTransactionLogReport]";

        public static string GetGuestLogReport = "[USP_GetGuestLogReport]";

        public static string SaveGSTtax = "[Usp_SaveGSTforTheGuest]";

        public static string ShowGSTTax = "[USP_GetGSTTax]";

        public static string GetTaxAmountsForInvoicePrint = "[USP_GetTaxAmountsForReceiptPrint]";

        //////////////////////////

        public static string GetEmailerReportList = "[USP_EmailerReportsList]";
        public static string GetEmailerAsSent = "[USP_MarkMailAsSent]";

        /////////////////
        /// 
        public static string GetAssignedRoomExtended = "[USP_AssignRoomExtendedTest]";

        public static string AddMoreGuest = "[USP_AddMoreGuests]";

        public static string SaveUserAccessLog = "[USP_SaveUserAccessLog]";

        public static string GetAllAdvanceAmount = "[USP_GetAdvancerReport]";

        public static string GetAllPostCharges = "[USP_GetPostChargesReport]";

        public static string HotelPositionDirectTest = "[USP_HotelPositionExtendedTEST]";

        public static string GetRestaurantSummary = "[USP_GetRestaurantSummaryForTheDay]";

        public static string GetDirectBookings = "[USP_GetDirectBookings]";

        #region Business Report
        public static string BusinessReportBySettlementType = "[USP_RptBusinessReportBySettlementType]";
        public static string BusinessReportByCompanyType = "[USP_RptBusinessReportByCompanyType]";
        public static string BusinessReportByMarketSegment = "[USP_RptBusinessReportByMarketSegment]";
        public static string OccupancyInHouseReport = "[USP_RptOccupancyInHouseReport]";
        public static string BusinessRevenueReport = "[USP_RptBusinessRevenueReport]";
        public static string PlanReport = "[USP_RptPlanReport]";
        #endregion

        public static string GetBookingOccupancyReport = "[USP_GetHotelOccupancyByBookings]";

        public static string GetAndSaveSelectedRoomsPostingRates = "[USP_SelectedRoomsPosting]";

        public static string DeleteAdvancePostedChargesOnRoom = "USP_DeleteReservationAdvanceByReservation";

        public static string GetGuestDetailsForVoucher = "[USP_GetGuestDataForVoucher]";

        public static string GetLicenceInformation = "[USP_CheckLINTBLQ]";

        public static string GetCompanyBookingReport = "[USP_GetCompanyAccountsReport]";

        public static string SaaveBreakfastReportLog = "[USP_SaveBreakfastReportLog]";

        public static string GetAdvanceSettlementReport = "[USP_GetAdvanceSettlementReport]";

        public static string ModifyTransactionsForAccDate = "[USP_ModifyRoomPosting]";

        public static string GetAllBillTransactionsManualSplitting = "[USP_GetAllBillTransactionsManualSplitting]";

        public static string ImportBookingFromWeb = "[USP_ImportBookingFromWeb]";

        public static string GetPostChargesOnRoom = "[USP_GetPostChargesOnRoom]";

        public static string SaveClientsEmails = "[USP_SaveClientsEmails]";
    }
}
