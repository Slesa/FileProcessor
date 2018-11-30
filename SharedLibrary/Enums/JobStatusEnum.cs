﻿namespace SharedLibrary.Enums
{
    public enum JobStatusEnum
    {
        Running,
        WorkerStarting,
        Finished,
        New,
        Terminated,
        FoundAvailableWorker,
        IsFaulted,
        WorkerFound,
        NoWorkersAvailable,
        NoRoutes,
        Canceled,
        GetRqHubData,
        GetInvoicesToProcess,
        ProcessingWeightedShare,
        ProcessingBonusTally,
        GetMarketEmployeesToRefresh,
        RefreshingMarket,
        Stopping,
        GettingToken,
        RetryGetData,
        SavingRqData,
        SavedRqHubData,
        Disabled,
        GettingTokenFailed,
        RetryGettingToken,
        FailedToGetInvoices,
        WaitingToStart,
        ServiceAlreadyRunning,
        RetryToStartJob,
        RetryToStartJobFailed,
        RetryDifferentWorker,
        ManagerStarting,
        JobHasStalledNeedRestart,
        FailedToGetEmployees,
        GetEmployeesDataForMarket,
        BatchCompleteRestarting,
        ServiceIsPaused,
        ServiceIsUnPaused,
        ServiceLoadedFromDB,
        Starting,
        RevertFailed,
        Complete,
        Failed,
        Processing
    }
}
