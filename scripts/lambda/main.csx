//Per fare il debug di questi esempi, devi prima installare il global tool dotnet-script con questo comando:
//dotnet tool install -g dotnet-script
//Trovi altre istruzioni nel file /scripts/readme.md

/*
//ESEMPIO #1: Definisco una lambda che accetta un parametro DateTime e restituisce un bool, e l'assegno alla variabile canDrive
Func<DateTime, bool> canDrive = dob => {
    return dob.AddYears(18) <= DateTime.Today;
};

//Eseguo la lambda passandole il parametro DateTime
DateTime dob = new DateTime(2002, 12, 25);
bool result = canDrive(dob);
//Poi stampo il risultato bool che ha restituito
Console.WriteLine(result);

//ESEMPIO #2: Stavolta definisco una lambda che accetta un parametro DateTime ma non restituisce nulla
Action<DateTime> printDate = date => Console.WriteLine(date);

//La invoco passandole l'argomento DateTime
DateTime date = DateTime.Today;
printDate(date);

/*** ESERCIZI! ***/

// ESERCIZIO #1: Scrivi una lambda che prende due parametri stringa (nome e cognome) e restituisce la loro concatenazione
// Func<...> concatFirstAndLastName = ...;
// Qui invoca la lambda

// ESERCIZIO #2: Una lambda che prende tre parametri interi (tre numeri) e restituisce il maggiore dei tre
// Func<...> getMaximum = ...;
// Qui invoca la lambda

// ESERCIZIO #3: Una lambda che prende due parametri DateTime e non restituisce nulla, ma stampa la minore delle due date in console con un Console.WriteLine
// Action<...> printLowerDate = ...;
// Qui invoca la lambda
*/

// parte scritta da me

//restituisce true o false per indicare la maggiore età o meno
Func<DateTime, bool> canDrive = dob => {
    return dob.AddYears(18) <= DateTime.Today;
};
DateTime dob = new DateTime(2006, 12, 25);
bool result = canDrive(dob);
Console.WriteLine(result);


//stampa la data di oggi
Action<DateTime> printDate = date => Console.WriteLine(date); 
DateTime date = DateTime.Today;
printDate(date);


//concatena nome e cognome
Func<String, String, String> concatFirstNameAndLastName = (FirstName, LastName) => FirstName + " " + LastName;
String completeName = concatFirstNameAndLastName("Danilo","Rosati");
Console.WriteLine(completeName);


//restituisce il maggiore di tre interi
Func<int, int, int, int> getMaximum = (firstNo, secondNo, therdNo) => Math.Max(firstNo, Math.Max(secondNo, therdNo));
int maximum = getMaximum(8, 9, 5);
Console.WriteLine(maximum);


//stampa la minore delle due date in input
Action<DateTime, DateTime> printLowerDate = (date1, date2) =>  Console.WriteLine((date1 < date2 ? date1 : date2));
DateTime date1 = new DateTime(2002,1,1);
DateTime date2 = new DateTime(2001,1,1);
printLowerDate(date1, date2);
