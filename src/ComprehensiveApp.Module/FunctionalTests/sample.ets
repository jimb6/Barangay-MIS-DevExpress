;#DropDB ComprehensiveAppEasyTest

#Application ComprehensiveAppWin
#Application ComprehensiveAppWeb
#IfDef ComprehensiveAppWin

*Action About...
 
*Action OK

#EndIf

#IfDef ComprehensiveAppWeb
*Action Navigation(My Details)
#EndIf
