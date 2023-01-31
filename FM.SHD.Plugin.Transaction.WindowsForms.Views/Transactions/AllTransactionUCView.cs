using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FM.SHD.Plugin.Transaction.WindowsForms.Presenters.NewDirectory1.Transactions;
using FM.SHDML.Core.Models.Dtos;

namespace FM.SHD.Plugin.Transaction.WindowsForms.Views.Transactions
{
    public partial class AllTransactionUCView : UserControl, IAllTransactionUCView
    {
        public AllTransactionUCView()
        {
            InitializeComponent();
        }

        private void DataGridTransactionUserControl_Load(object sender, System.EventArgs e)
        {
            dataGridViewTransaction.MultiSelect = false;
            dataGridViewTransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridViewTransaction_SelectionChanged(object sender, System.EventArgs e)
        {
            //MessageBox.Show("");
        }

        public BindingList<TransactionExtendedDto> _transactionExtendedDtos;

        public void SetData(List<TransactionExtendedDto> allTransactionsDtos)
        {
            _transactionExtendedDtos = new BindingList<TransactionExtendedDto>(allTransactionsDtos);
            dataGridViewTransaction.AutoGenerateColumns = false;
            dataGridViewTransaction.DataSource = _transactionExtendedDtos;
        }

        public void SetData(TransactionExtendedDto transactionsDtos)
        {
            foreach (DataGridViewRow selectedRow in dataGridViewTransaction.SelectedRows)
            {
                selectedRow.Cells[1].Value = transactionsDtos.Name;
                selectedRow.Cells[2].Value = transactionsDtos.Description;
                selectedRow.Cells[3].Value = transactionsDtos.Sum;
                selectedRow.Cells[4].Value = transactionsDtos.Date;
                selectedRow.Cells[5].Value = transactionsDtos.Category;
                selectedRow.Cells[6].Value = transactionsDtos.Contragent;
                selectedRow.Cells[7].Value = transactionsDtos.Identity;
                selectedRow.Cells[8].Value = transactionsDtos.DebitAccount;
                selectedRow.Cells[9].Value = transactionsDtos.CreditAccount;
            }
        }

        public void ClearData()
        {
            dataGridViewTransaction.Rows.Clear();
        }

        public event Action<TransactionExtendedDto> UpdateTransaction;

        private void dataGridViewTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTransaction.CurrentCell.ColumnIndex != 0 && e.RowIndex != -1)
            {
                foreach (var transactionExtendedDto in _transactionExtendedDtos)
                {
                    if (transactionExtendedDto.Id.ToString() ==
                        dataGridViewTransaction.CurrentRow.Cells[0].Value.ToString())
                    {
                        UpdateTransaction?.Invoke(transactionExtendedDto);
                        break;
                    }
                }
            }
        }
    }
}