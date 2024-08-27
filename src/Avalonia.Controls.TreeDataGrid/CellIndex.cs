namespace Avalonia.Controls
{
    /// <summary>
    /// Represents a cell in a <see cref="TreeDataGrid"/>.
    /// </summary>
    /// <param name="ColumnIndex">
    /// The index of the cell in the <see cref="TreeDataGrid.Columns"/> collection.
    /// </param>
    /// <param name="RowIndex">
    /// The hierarchical index of the row model in the data source.
    /// </param>
    public readonly struct CellIndex
    {
        public CellIndex(int columnIndex, IndexPath rowIndex)
        {
            ColumnIndex = columnIndex;
            RowIndex = rowIndex;
        }
        
        public int ColumnIndex { get; }
        public IndexPath RowIndex { get; }
    }
}
