Option Strict On
Public Class Car


    Private Shared _carCount As Integer                 ' static or shared private variable to hold the number of cars
    Private _carIdentificationNumber As Integer = 0     ' private variable to hold the car's identification number
    Private _carMake As String = String.Empty         ' private variable to hold the car's make
    Private _carModel As String = String.Empty     ' private variable to hold the car's model
    Private _carYear As String = String.Empty      ' private variable to hold the car's year
    Private _carPrice As String = String.Empty      ' private variable to hold the car's price
    Private _carStatus As Boolean = False              ' private variable to hold the car's status

    ''' <summary>
    ''' Constructor - Default - creates a new car object
    ''' </summary>
    Public Sub New()

        _carCount += 1      ' increment the shared/static variable counter by 1
        _carIdentificationNumber = _carCount ' assign the cars id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new car object
    ''' </summary>
    ''' <param name="carMake"></param>
    ''' <param name="carModel"></param>
    ''' <param name="carYear"></param>
    ''' <param name="carPrice"></param>
    ''' <param name="carStatus"></param>
    Public Sub New(carMake As String, carModel As String, carYear As String, carPrice As String, carStatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        _carMake = carMake          ' set the car make
        _carModel = carModel  ' set the car model
        _carYear = carYear    ' set the car year
        _carPrice = carPrice  ' set the car price
        _carStatus = carStatus        ' set the car status

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property CarCount() As Integer
        Get
            Return _carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific cars identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property CarIdentificationNumber() As Integer
        Get
            Return _carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' Status Property - >Gets and Sets the Very Important Person status of a car
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property CarStatus() As Boolean
        Get
            Return _carStatus
        End Get
        Set(ByVal carStatus As Boolean)
            _carStatus = carStatus
        End Set
    End Property

    ''' <summary>
    ''' Make property - Gets and Sets the make of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property CarMake() As String
        Get
            Return _carMake
        End Get
        Set(ByVal carMake As String)
            _carMake = carMake
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the model of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property CarModel() As String
        Get
            Return _carModel
        End Get
        Set(ByVal carModel As String)
            _carModel = carModel
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As String
        Get
            Return _carPrice
        End Get
        Set(ByVal carPrice As String)
            _carPrice = carPrice
        End Set
    End Property

    Public Property Year() As String
        Get
            Return _carYear
        End Get
        Set(ByVal carYear As String)
            _carYear = carYear
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetSalutation() As String

        Return "Hi my name is " & _carMake & " " & _carModel & " " & _carYear & ", " & _carPrice & ", " & IIf(_carStatus = True, " The car is new", " the car is not new").ToString()

    End Function


End Class
