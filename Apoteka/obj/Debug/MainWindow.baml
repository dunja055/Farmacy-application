   M S B A M L   `   `   `  ����B  >Apoteka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ApotekaApoteka  5   	       Apoteka.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Apoteka     5   	     � Title$  Apoteka��5   	   $	��350��6   $	��620��6&   .��5	      � ��5
   
   �� 5       �� ImageSource$" C:\Users\Dunja\Desktop\a.png��6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridCentralni��5      $��Center=�6.   $��Center=�6K   $
��auto��5      $
��auto��6!      AlternatingRowBackground
 ��ح�   
IsReadOnly .    CanUserAddRows .     SelectionUnit$ FullRow=�5         SelectionMode$ Single=�6+   �� 5   
   $��Center=�6   $��30��62   $	��Top=�6>   $
��auto��6V    �� Orientation$ 
Horizontal=�6c   .+�5      �� -   5        	 ��Name$	 btnDobavljaci��5      $��
Dobavljaci��6,   $
��Left=�6A   $	��Top=�6]   $��75��6u   $��30��6�   
����ح�6�   �� 5      -   5        $	 btnFarmaceuti��5      $��
Farmaceuti��6,   $
��Left=�6A   $	��Top=�6]   $��75��6u   $��30��6�   
����ح�6�   �� 5      -   5        $	 btnKupci��5      $��Kupci��6'   $
��Left=�67   $	��Top=�6S   $��75��6k   $��30��6v   
����ح�6�   �� 5      -   5        $	 
btnNabavke��5      $��Nabavke��6)   $
��Left=�6;   $	��Top=�6W   $��75��6o   $��30��6z   
����ح�6�   �� 5      -   5        $	 btnPlacanje��5      $��Placanje��6*   $
��Left=�6=   $	��Top=�6Y   $��75��6q   $��30��6|   
����ح�6�   �� 5      -   5        $	 btnProizvodi��5      $��	Proizvodi��6+   $
��Left=�6?   $	��Top=�6[   $��75��6s   $��30��6~   
����ح�6�   �� 5      -   5        $	 btnVrsteProizvoda��5      $��VrsteProizvoda��60   $
��Left=�6I   $	��Top=�6e   $��75��6}   $��30��6�   
����ح�6�   5      �� 5   
   $��Center=�6   $��30��62   $��Bottom=�6?   $	��352��6Z   $ 
Horizontal=�6f   .+�5      �� -	   5        $	 btnDodajDobavljaca��5      $��Dodaj dobavljaca��61   $	��117��6L   
����ح�6o   �� 5      -
   5        $	 btnIzmeniDobavljaca��5      $��Izmeni dobavljaca��62   $	��117��6N   
����ح�6q   �� 5      -   5        $	 btnObrisiDobavljaca��5      $��Obrisi dobavljaca��62   $	��117��6N   
����ح�6q   �� 5      -   5        $	 btnDodajFarmaceuta��5      $��Dodaj farmaceuta��61   $	��117��6L   
����ح�6o   �� 5       -   5        $	 btnIzmeniFarmaceuta��5       $��Izmeni farmaceuta��62   $	��117��6N   
����ح�6q   �� 5!      -   5        $	 btnObrisiFarmaceuta��5!      $��Obrisi farmaceuta��62   $	��117��6N   
����ح�6q   �� 5#      -   5        $	 btnDodajKupca��5#      $��Dodaj kupca��6,   $	��117��6B   
����ح�6e   �� 5$      -   5        $	 btnIzmeniKupca��5$      $��Izmeni kupca��6-   $	��117��6D   
����ح�6g   �� 5%      -   5        $	 btnObrisiKupca��5%      $��Obrisi kupca��6-   $	��117��6D   
����ح�6g   �� 5'      -   5        $	 btnDodajNabavku��5'      $��Dodaj nabavku��6.   $	��117��6F   
����ح�6i   �� 5(      -   5        $	 btnIzmeniNabavku��5(      $��Izmeni nabavku��6/   $	��117��6H   
����ح�6k   �� 5)      -   5        $	 btnObrisiNabavku��5)      $��Obrisi nabavku��6/   $	��117��6H   
����ح�6k   �� 5+      -   5        $	 btnDodajPlacanje��5+      $��Dodaj placanje��6/   $	��117��6H   
����ح�6k   �� 5,      -   5        $	 btnIzmeniPlacanje��5,      $��Izmeni placanje��60   $	��117��6J   
����ح�6m   �� 5-      -   5        $	 btnObrisiPlacanje��5-      $��Obrisi placanje��60   $	��117��6J   
����ح�6m   �� 5/      -   5        $	 btnDodajProizvod��5/      $��Dodaj proizvod��6/   $	��117��6H   
����ح�6k   �� 50      -   5        $	 btnIzmeniProizvod��50      $��Izmeni proizvod��60   $	��117��6J   
����ح�6m   �� 51      -   5        $	 btnObrisiProizvod��51      $��Obrisi proizvod��60   $	��117��6J   
����ح�6m   �� 53      -   5        $	 btnDodajVrstuProizvoda��53      $��Dodaj vrstu proizvoda��65   $	��117��6U   
����ح�6x   �� 54      -   5        $	 btnIzmeniVrstuProizvoda��54      $��Izmeni vrstu proizvoda��66   $	��117��6W   
����ح�6z   �� 55      -   5        $	 btnObrisiVrstuProizvoda��55      $��Obrisi vrstu proizvoda��66   $	��117��6W   
����ح�6z   56      58      59      