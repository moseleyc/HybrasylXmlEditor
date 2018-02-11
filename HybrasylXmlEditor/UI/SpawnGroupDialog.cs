/*
 * This file is part of Project Hybrasyl.
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the Affero General Public License as published by
 * the Free Software Foundation, version 3.
 *
 * This program is distributed in the hope that it will be useful, but
 * without ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
 * or FITNESS FOR A PARTICULAR PURPOSE. See the Affero General Public License
 * for more details.
 *
 * You should have received a copy of the Affero General Public License along
 * with this program. If not, see <http://www.gnu.org/licenses/>.
 *
 * (C) 2016 Project Hybrasyl (info@hybrasyl.com)
 *
 */

using Hybrasyl.Creatures;
using Hybrasyl.XML;
using HybrasylXmlEditor.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HybrasylXmlEditor.UI
{
    public partial class SpawnGroupDialog : Form
    {
        private SpawnGroupViewModel SpawnGroupVM;

        public SpawnGroupDialog()
        {
            InitializeComponent();
        }

        private void SpawnGroupDialog_Load(object sender, EventArgs e)
        {
            SpawnGroupVM = new SpawnGroupViewModel(new SpawnGroup());
            SpawnGroupVM.SetDisplaySpawnGroup(new SpawnGroup());
            setBindings();
            setupGridView();
        }

        private void setBindings()
        {
            dataGridViewMaps.AutoGenerateColumns = false;
            dataGridViewMaps.DataSource = SpawnGroupVM.Maps;

            dataGridViewSpawns.AutoGenerateColumns = false;
            dataGridViewSpawns.AllowUserToAddRows = false;
            dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
        }

        private void setupGridView()
        {
            #region Map
            dataGridViewMaps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMaps.MultiSelect = false;
            dataGridViewMaps.RowHeadersVisible = false;
            dataGridViewMaps.AllowUserToOrderColumns = false;
            dataGridViewMaps.AllowUserToResizeColumns = false;
            dataGridViewMaps.AllowUserToResizeRows = false;
            dataGridViewMaps.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn mapName = new DataGridViewTextBoxColumn();
            mapName.Name = "Name";
            mapName.DataPropertyName = "Name";
            mapName.HeaderText = "Name";
            mapName.Width = 209;
            mapName.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapName.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapName.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaps.Columns.Add(mapName);

            DataGridViewTextBoxColumn mapMinSpawn = new DataGridViewTextBoxColumn();
            mapMinSpawn.Name = "MinSpawn";
            mapMinSpawn.DataPropertyName = "MinSpawn";
            mapMinSpawn.HeaderText = "MinSpawn";
            mapMinSpawn.Width = 75;
            mapMinSpawn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapMinSpawn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapMinSpawn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaps.Columns.Add(mapMinSpawn);

            DataGridViewTextBoxColumn mapMaxSpawn = new DataGridViewTextBoxColumn();
            mapMaxSpawn.Name = "MaxSpawn";
            mapMaxSpawn.DataPropertyName = "MaxSpawn";
            mapMaxSpawn.HeaderText = "MaxSpawn";
            mapMaxSpawn.Width = 75;
            mapMaxSpawn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapMaxSpawn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapMaxSpawn.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaps.Columns.Add(mapMaxSpawn);

            DataGridViewTextBoxColumn mapLimit = new DataGridViewTextBoxColumn();
            mapLimit.Name = "Limit";
            mapLimit.DataPropertyName = "Limit";
            mapLimit.HeaderText = "Limit";
            mapLimit.Width = 75;
            mapLimit.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapLimit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapLimit.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaps.Columns.Add(mapLimit);

            DataGridViewTextBoxColumn mapInterval = new DataGridViewTextBoxColumn();
            mapInterval.Name = "Interval";
            mapInterval.DataPropertyName = "Interval";
            mapInterval.HeaderText = "Interval";
            mapInterval.Width = 75;
            mapInterval.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapInterval.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            mapInterval.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewMaps.Columns.Add(mapInterval);
            #endregion

            #region Spawn
            dataGridViewSpawns.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSpawns.MultiSelect = false;
            dataGridViewSpawns.RowHeadersVisible = false;
            dataGridViewSpawns.AllowUserToOrderColumns = false;
            dataGridViewSpawns.AllowUserToResizeColumns = false;
            dataGridViewSpawns.AllowUserToResizeRows = false;
            dataGridViewSpawns.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            DataGridViewTextBoxColumn spawnBase = new DataGridViewTextBoxColumn();
            spawnBase.Name = "Base";
            spawnBase.DataPropertyName = "Base";
            spawnBase.HeaderText = "Base";
            spawnBase.Width = 268;
            spawnBase.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            spawnBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            spawnBase.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewSpawns.Columns.Add(spawnBase);

            DataGridViewTextBoxColumn spawnVariance = new DataGridViewTextBoxColumn();
            spawnVariance.Name = "Variance";
            spawnVariance.DataPropertyName = "Variance";
            spawnVariance.HeaderText = "Variance";
            spawnVariance.Width = 75;
            spawnVariance.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            spawnVariance.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            spawnVariance.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewSpawns.Columns.Add(spawnVariance);
            #endregion
        }

        private void buttonNewXml_Click(object sender, EventArgs e)
        {
            SpawnGroupVM.SetDisplaySpawnGroup(new SpawnGroup());
            dataGridViewMaps.DataSource = SpawnGroupVM.Maps;
            dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
        }

        private void buttonSaveXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveSpawnGroupXML = new SaveFileDialog();
            saveSpawnGroupXML.Filter = "(XML)|*.xml";
            if (saveSpawnGroupXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fileName = saveSpawnGroupXML.FileName;
                    XmlWriterSettings xmlSettings = new XmlWriterSettings();
                    xmlSettings.Indent = true;
                    xmlSettings.IndentChars = "\t";

                    XmlWriter xmlWriter = XmlWriter.Create(fileName, xmlSettings);
                    var test = SpawnGroupVM;
                    Serializer.Serialize(xmlWriter, SpawnGroupVM.GetDisplaySpawnGroup());

                    xmlWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Problem saving file");
                }

            }
        }

        private void buttonLoadXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadSpawnGroupXML = new OpenFileDialog();
            loadSpawnGroupXML.Filter = "(XML)|*.xml";
            XmlReader reader = null;
            if (loadSpawnGroupXML.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XmlReaderSettings settings = new XmlReaderSettings();
                    settings.IgnoreComments = true;

                    reader = XmlReader.Create(loadSpawnGroupXML.FileName, settings);
                    SpawnGroup nullSpawnGroup = null;
                    var readSpawnGroup = Serializer.Deserialize(reader, nullSpawnGroup);
                    SpawnGroupVM.SetDisplaySpawnGroup(readSpawnGroup);
                    dataGridViewMaps.DataSource = SpawnGroupVM.Maps;
                    dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Problem with loading the file");
                }
                finally
                {
                    if(reader != null) reader.Close();
                }
            }
        }

        private void buttonAddSpawn_Click(object sender, EventArgs e)
        {
            SpawnDialog spawnDialog = new SpawnDialog();
            spawnDialog.SpawnVM = new SpawnViewModel(new Spawn());

            if (spawnDialog.ShowDialog() == DialogResult.OK)
            {
                SpawnGroupVM.Spawn.Add(spawnDialog.SpawnVM.GetDisplaySpawn());
                dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
            }
            spawnDialog.Dispose();
        }

        private void buttonEditSpawn_Click(object sender, EventArgs e)
        {
            if(dataGridViewSpawns.CurrentRow != null)
            {
                int index = dataGridViewSpawns.CurrentRow.Index;
                SpawnDialog spawnDialog = new SpawnDialog();
                spawnDialog.SpawnVM = new SpawnViewModel(SpawnGroupVM.Spawn[index]);
                if (spawnDialog.ShowDialog() == DialogResult.OK)
                {
                    SpawnGroupVM.Spawn.Add(spawnDialog.SpawnVM.GetDisplaySpawn());
                    dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
                    SpawnGroupVM.Spawn.ResetItem(index);
                }
                spawnDialog.Dispose();
            }
            else
            {
                MessageBox.Show("No rows or no row selected.");
            }
            
        }

        private void buttonDeleteSpawn_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpawns.CurrentRow != null)
            {
                int index = dataGridViewSpawns.CurrentRow.Index;
                SpawnGroupVM.Spawn.RemoveAt(index);

                dataGridViewSpawns.DataSource = SpawnGroupVM.Spawn;
            }
            else
            {
                MessageBox.Show("No rows or no row selected.");
            }
        }
    }
}
