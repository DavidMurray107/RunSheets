using Contracts;
using Entities;
namespace Repository
{
   public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IDataFieldRepository _datafield;
        private IInputTypeRepository _inputType;
        private IRunsheetRepository _runsheet;
        private ISubSectionRepository _subsection;
        private IReportEntryRepository _reportEntry;
        private IReportDataEntryRepository _reportDataEntry;

        public IDataFieldRepository DataField
        {
            get
            {
                if(_datafield == null)
                {
                    _datafield = new DataFieldRepository(_repoContext);
                }

                return _datafield;
            }
        }

        public IInputTypeRepository InputType
        {
            get
            {
                if (_inputType == null)
                {
                    _inputType = new InputTypeRepository(_repoContext);
                }

                return _inputType;
            }
        }

        public IRunsheetRepository Runsheet
        {
            get
            {
                if (_runsheet == null)
                {
                    _runsheet = new RunsheetRepository(_repoContext);
                }

                return _runsheet;
            }
        }

        public ISubSectionRepository SubSection
        {
            get
            {
                if (_subsection == null)
                {
                    _subsection = new SubSectionRepository(_repoContext);
                }

                return _subsection;
            }
        }

        public IReportEntryRepository ReportEntry
        {
            get
            {
                if (_reportEntry == null)
                {
                    _reportEntry = new ReportEntryRepository(_repoContext);
                }

                return _reportEntry;
            }
        }
        public IReportDataEntryRepository DataEntry
        {
            get
            {
                if (_reportDataEntry == null)
                {
                    _reportDataEntry = new ReportDataEntryRepository(_repoContext);
                }

                return _reportDataEntry;
            }
        }
        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
