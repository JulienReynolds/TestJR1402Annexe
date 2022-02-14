int age;
int calculage;


   public IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Prenom,datedenaissance")] Personne personne)
        {
            age = //selectionner 4 dernier caractéres de datedenaissance
            calculage = 2022-//4 derniers caractéres
            if(calculage>=150) {
            lable.text = "Erreur" ;
            }
           
                else{ 
                     
            if (ModelState.IsValid)
            {
                _context.Add(personne);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personne);
        }
        }
        




