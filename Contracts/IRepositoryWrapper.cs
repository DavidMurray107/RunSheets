namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IDataFieldRepository DataField { get; }
        IInputTypeRepository InputType { get; }
        IRunsheetRepository Runsheet { get; }
        ISubSectionRepository SubSection { get; }
        IReportEntryRepository ReportEntry { get; }
        IReportDataEntryRepository DataEntry { get; }
        void Save();
        
    }
}
