﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Mining_Application.Classes
{
    public static class importDataForComboBox
    {
        public static void LoadType(ComboBox comboBox)
        {
            var query = connectClass.db.MineralType.Select(item => new
            {
                minType = item.Type
            });
            var collectionType = from selectedItem in query select selectedItem.minType;
            comboBox.ItemsSource = collectionType.ToList();
        }

        public static void LoadField(ComboBox comboBox)
        {
            var query = connectClass.db.Field.Select(item => new
            {
                minField = item.FieldName
            });
            var collectionType = from selectedItem in query select selectedItem.minField;
            comboBox.ItemsSource = collectionType.ToList();
        }
    }
}
