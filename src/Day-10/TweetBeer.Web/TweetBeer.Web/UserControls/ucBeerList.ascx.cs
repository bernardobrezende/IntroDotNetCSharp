﻿using System;
using System.Linq;
using System.Web.UI.WebControls;
using TweetBeer.Web.Models;

namespace TweetBeer.Web.UserControls
{
    public partial class ucBeerList : System.Web.UI.UserControl
    {
        internal ListItem SelectedBeer
        {
            get { return this.ddlBeerList.SelectedItem; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            // Exercício: Preencher DropDownList do controle
            // com as cervejas que estiverem no banco de dados TweetBeer!
            // Lembrem-se: cada item terá um value (Id) e um text (Name)
            // Lembrem-se 2: este carregamento deve ser executado apenas uma vez!

            if (!IsPostBack)
            {
                using (TweetBeerContainer dbContainer = new TweetBeerContainer())
                {
                    var listItems = (from b in dbContainer.Beer.ToList()
                                 select new ListItem(b.Name, b.Id.ToString())).ToArray();

                    foreach (var li in listItems)
                    {
                        if (this.ddlBeerList.Items
                            .Cast<ListItem>()
                            .Count(x => x.Text == li.Text) == 0)
                        {
                            this.ddlBeerList.Items.Add(li);
                        }
                    }                   
                }
            }
        }

        internal void RemoveSelectedBeer()
        {
            if (this.SelectedBeer == null)
            {
                this.lblError.Visible = true;                
            }
            else
                this.ddlBeerList.Items.Remove(this.SelectedBeer);
        }
    }
}