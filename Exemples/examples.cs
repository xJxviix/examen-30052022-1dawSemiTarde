/***********************************************
*       Ejemplo de cambiar de vistas WPF       *
***********************************************/
private void OpenModalAddItem(object sender, RoutedEventArgs e)
{
    var dialogAddNameItem = new AddItemModal("hola")
    {
        Owner = this
    };

    if (dialogAddNameItem.ShowDialog() == true)
    {
        listBox.Items.Add(dialogAddNameItem.Value);
    }
}

 private void AddItem(object sender, RoutedEventArgs e)
{
    _value = nameTextBox.Text.ToString();
    DialogResult = true;
}

private void Close(object sender, RoutedEventArgs e)
{
    DialogResult = false;
}

/***********************************************
*       Ejemplo de cambiar de vistas WF        *
***********************************************/

private void button4_Click(object sender, EventArgs e)
{
    Form2 frm = new Form2();
    if (frm.ShowDialog() == DialogResult.OK)
    {
        string cadena1 = frm.cad1;
        string cadena1 = frm.cad2;
        bool boleano1 = frm.bl1;
        bool boleano2  = frm.bl2;
        
    }
}

private void button1_Click(object sender, EventArgs e)
{
    cad1 = "esta es tu primera cadena";
    cad2 = "esta es tu segundacadena";
    bl1= true;
    bl2= false;
    this.DialogResult = DialogResult.OK;
    this.Close();
}