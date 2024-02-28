namespace ESERCIZIOL2.Models
{
    public static class StaticDb
    {
        private static int _maxId = 6;
        private static List<Employees> _employees = [
            new Employees(){Id= 1, Nome = "Marco", Cognome = "Antenucci", Indirizzo = "Via della Repubblica", Coniugato = true, NumeroFigli = 4, Mansione = "Pizzaiolo" },
            new Employees(){Id= 2, Nome = "Silvio", Cognome = "Pellico", Indirizzo = "Via Pellicani", Coniugato = true, NumeroFigli = 3, Mansione = "Rivoltoso" },
            new Employees(){Id= 3, Nome = "Matteo", Cognome = "Grasso", Indirizzo = "Via le mani dal naso", Coniugato = false, NumeroFigli = 0, Mansione = "Barbiere" },
            new Employees(){Id= 4, Nome = "Riccardo", Cognome = "Valentino", Indirizzo = "Via Squinzano", Coniugato = false, NumeroFigli = 0, Mansione = "Agente di commercio" }
        ];

        public static List<Employees> GetAll()
        {
            return _employees;
        }

        public static Employees? GetById(int? id)
        {
            if (id is null) return null;
            for (int i = 0; i < _employees.Count; i++)
            {
                Employees employees = _employees[i];
                if (employees.Id == id)
                {
                    return employees;
                }
            }

            return null;
        }
        public static Employees Add(string nome, string cognome, string indirizzo, bool coniugato, int numeroFigli, string mansione)
        {
            _maxId++;

            var employees = new Employees() { Id = _maxId, Nome = nome, Cognome = cognome, Indirizzo = indirizzo, Coniugato = coniugato, NumeroFigli = numeroFigli, Mansione = mansione };
            _employees.Add(employees);
            return employees;
        }
    }
    private static List<Payment> _payment = new List<Payment>()
      {
            new Payment(){Id= 1, Totale = 1450, periodoPagamento ="Novembre"},
            new Payment(){Id= 2, Totale =1500, periodoPagamento ="Dicembre"},
            new Payment(){Id= 3, Totale =1750, periodoPagamento ="Gennaio"},
            new Payment(){Id= 4, Totale =1800, periodoPagamento ="Febbraio"}

      };

    public static List<Payment> GetAllPayment()
    {
        return _payment;
    }

    public static Payment Add(decimal totale, string periodoPagamento)
    {
        _maxId++;

        var payment = new Payment() { Id = _maxId, Totale = totale, periodoPagamento = periodoPagamento };
        _payment.Add(payment);
        return payment;
    }

}




