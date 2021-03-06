﻿namespace Hidistro.UI.Common.Controls
{
    using Entities.Insurance;
    using Hidistro.Entities.CashBack;
    using System;
    using System.Web.UI.WebControls;

    public class InsuranceOrderTypesDropDownList : DropDownList
    {
        public override void DataBind()
        {
            this.Items.Clear();
            this.Items.Add(new ListItem("***请选择***", ""));
            foreach (int num in Enum.GetValues(typeof(InsuranceOrderTypes)))
            {
                string text = ((InsuranceOrderTypes) num).ToString();
                this.Items.Add(new ListItem(text, num.ToString()));
            }
        }

        public int? SelectedValue
        {
            get
            {
                if (string.IsNullOrEmpty(base.SelectedValue))
                {
                    return null;
                }
                return new int?(int.Parse(base.SelectedValue));
            }
            set
            {
                if (value.HasValue)
                {
                    base.SelectedIndex = base.Items.IndexOf(base.Items.FindByValue(value.Value.ToString()));
                }
            }
        }
    }
}

