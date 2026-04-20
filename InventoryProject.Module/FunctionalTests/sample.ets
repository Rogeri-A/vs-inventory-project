;#DropDB InventoryProjectEasyTest

#Application InventoryProject.Win
#Application InventoryProject.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef InventoryProject.Win

*Action About...
 
*Action OK

#EndIf

#IfDef InventoryProject.Web
*Action Navigation(My Details)
#EndIf
