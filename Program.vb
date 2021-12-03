'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 25/11/2021
' Time: 12:21
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimensions the arrays and variables needed for use in the program
		Dim player(20) As String
		Dim goal(20) As Int64
		Dim sort(20) As Int64
		Dim nameSort(20) As String
		Dim choice As String = ""
		Dim search As String = ""
		Dim updateGoal As Int16 = 0
		Dim newPlayer As String = ""
		Dim newGoal As Int16 = 0
		Dim exit1 As Int16 = 0
		Dim max As Int16 = 0
		
		'Enters the users favourite players into the array
		player(1) = "A"
		player(2) = "B"
		player(3) = "C"
		player(4) = "D"
		player(5) = "E"
		player(6) = "F"
		player(7) = "G"
		player(8) = "H"
		player(9) = "I"
		player(10) = "J"

		'A do loop until q is pressed so that he program quits
		Do Until choice = "q"
			'A menu for finding your way around the prgram
			Console.WriteLine("Please enter 1 for displaying names and goal tally, 2 for editing the amount of goals a player has scored, 3 for adding in new players, 4 for deleting players and q to quit")
			choice = Console.ReadLine()
			'If choice = 1 the program will print out all of the player's names and their goal tally in a list. if there is no data then the name and tally would not be printed
			If choice = "1" Then
				Console.Clear()
				Console.WriteLine("Player		Goals")
				For c=1 To 20
					If player(c) = "" Then
						
					Else
						Console.WriteLine(player(c) & "		" & goal(c))
					End If
				Next
			End If
			'If choice = 2 then the program would search through the player array until it finds the name and update the goal tally
			If choice = "2" Then
				Console.WriteLine("Please enter the name of the player to change")
				search = Console.ReadLine()
				For c=1 To 20
					If player(c) = search Then
						Console.WriteLine("Please enter the updated goal tally")
						goal(c) = Console.ReadLine()
					End If
				Next
			End If
			'if choice  3 Then the program will ask for 10 player's name and goals and add them to the array.
			If choice = "3" Then
				Console.WriteLine("Please enter the name of the new player")
				newPlayer = Console.ReadLine()
				Console.WriteLine("Please enter the goal tally")
				newGoal = Val(Console.ReadLine())
				For c=1 To 20
					If player(c) = "" Then
						player(c) = newPlayer
						goal(c) = newGoal
						Exit For
					End If
				Next
			End If
			'If choice = 4 then the program will search through the player array until it find the entered player's name and delete the name and goal tally.
			If choice = "4" Then
				Console.WriteLine("Please enter the name of the footballer to be deleted")
				search = Console.ReadLine()
				For c=1 To 20
					If player(c) = search Then
						player(c) = ""
						goal(c) = 0
						Console.WriteLine("Player sucessfully deleted")
					End If
				Next
			End If
			'If choice = 5 then the program will copy all the data into a new array and will then sort the new array by the amoint of goals scored.
			If choice = "5" Then
				For c=1 To 20
					sort(c) = goal(c)
					nameSort(c) = player(c)
				Next
				Array.Sort(sort, nameSort)
				For d=20 To 1 Step - 1
					If nameSort(d) = "" Then
					Else
						Console.WriteLine(nameSort(d) & "	" & sort(d))
					End If
				Next
			End If
		Loop
	End Sub
End Module
