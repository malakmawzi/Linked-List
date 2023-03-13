Module Module1

    Sub Main()
        Public Class Node
        Public value As Integer
        Public nextNode As Node

        Public Sub New(ByVal val As Integer)
            value = val
            nextNode = Nothing
        End Sub
    End Class

    Public Class LinkedList
        Private head As Node
        Private tail As Node

        Public Sub New()
            head = Nothing
            tail = Nothing
        End Sub

        Public Function addNode(ByVal value As Integer) As Node
            Dim newNode As Node = New Node(value)
            If head Is Nothing Then
                head = newNode
                tail = newNode
            Else
                tail.nextNode = newNode
                tail = newNode
            End If
            Return newNode
        End Function

        Public Function removeNode(ByVal value As Integer) As Node
            Dim current As Node = head
            Dim previous As Node = Nothing

            While current IsNot Nothing
                If current.value = value Then
                    If previous Is Nothing Then
                        head = current.nextNode
                    Else
                        previous.nextNode = current.nextNode
                    End If
                    If current.nextNode Is Nothing Then
                        tail = previous
                    End If
                    Return current
                End If
                previous = current
                current = current.nextNode
            End While

            Return Nothing
        End Function

        Public Sub displayList()
            Dim current As Node = head
            While current IsNot Nothing
                Console.Write(current.value & " ")
                current = current.nextNode
            End While
            Console.WriteLine()
        End Sub
    End Class

    End Sub

End Module
