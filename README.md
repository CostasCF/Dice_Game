# Dice_Game
A simple game created with Visual C#. 

ΠΑΝΕΠΙΣΤΗΜΙΟ ΠΕΙΡΑΙΩΣ

Τμήμα Πληροφορικής

Εργασία Μαθήματος: ΑΝΤΙΚΕΙΜΕΝΟΣΤΡΕΦΗΣ ΑΝΑΠΤΥΞΗ ΕΦΑΡΜΟΓΩΝ




## 1 Εισαγωγή

```
Στόχος της εργασίας είναι η υλοποίηση ενός παιχνιδιού το οποίο περιλαμβάνει ένα μενού
επιλογών για τον χρήστη, διαφορετικά επίπεδα δυσκολίας και απλή αποθήκευση δεδομένων.
Επίσης, το παιχνίδι περιλαμβάνει ένα ζάρι το οποίο ο χρήστης καλείτε να το πετύχει όσο πιο
πολλές φορές μπορεί σε ένα ορισμένο χρονικό διάστημα(20 δευτερόλεπτα) μέσα μια
συγκεκριμένη περιοχή. Τέλος, με βάση το επίπεδο δυσκολίας σε συνδυασμό με τις φορές
που πέτυχε το ζάρι ο χρήστης, υπολογίζεται το τελικό σκορ.
```
## 2 Περιγραφή του προγράμματος

```
Το πρόγραμμα υλοποιήθηκε στο Visual Studio 2019 με την χρήση windows forms(Visual C#).
Για την υλοποίηση του μενού, κρίθηκε επιτακτική η χρήση των panels από το toolbox και η
εναλλαγή τους, ανάλογα πάντα με την συμπεριφορά του χρήστη πάνω στα διάφορα event
των buttons, με την λειτουργία Hide() και Show() κάθε φορά. Σημαντικό είναι επίσης να
αναφερθεί η βοήθεια που παρείχε το Document Outline(View - > Other Windows) που παρέχει
το Visual Studio για την βέλτιστη διαχείριση των panel και των λειτουργιών τους πάνω σε
αυτά. Για την αποθήκευση των διαφόρων δεδομένων του χρήστη (σκορ, όνομα, επίπεδο
δυσκολίας) χρησιμοποιήθηκε ένα απλό txt file για αυτή την περίπτωση. Τέλος, το τελικό σκορ
υπολογίστηκε με βάση ενός πολλαπλασιαστή ώστε να είναι ισορροπημένο σε κάθε επίπεδο
δυσκολίας.
Για περισσότερες λεπτομέρειες, ο κώδικας είναι εμπλουτισμένος με σχόλια οπού μπορεί να
ανατρέξει κάποιος για την λεπτομερή περιγραφή των παραπάνω λειτουργιών.
```


## 3 Επίδειξη της λύσης

```
Εδώ θα παρουσιαστούν εικόνες μέσα από την λειτουργία του παιχνιδιού.
```

```
Εικόνα 1 Αρχικό μενού
```
![Dice1](https://user-images.githubusercontent.com/52785685/101353018-a1c41280-389b-11eb-93a1-1a9ada7dc600.png)
<br>

```
Εικόνα 2 Μενού επιλογών του χρήστη
```
![Dice2](https://user-images.githubusercontent.com/52785685/101353179-dd5edc80-389b-11eb-9030-d24b534e29f3.png)
<br>
```
Εικόνα 3 Authentication στο αν έδωσε επιλογές ο χρήστης και η εμφάνιση συγκεκριμένων μηνυμάτων.
```
![Dice3](https://user-images.githubusercontent.com/52785685/101353273-f9fb1480-389b-11eb-8933-00dda7521b35.png)
<br>
```
Εικόνα 4 Gameplay του παιχνιδιού. Πάνω δεξιά παρατηρείται το σκορ και ο υπολειπόμενος χρόνος.
```
![Dice4](https://user-images.githubusercontent.com/52785685/101353298-04b5a980-389c-11eb-8b6e-41e0583d35c2.png)
<br>
```
Εικόνα 5 Τερματισμός του παιχνιδιού και η δυνατότητα δύο επιλογών στον χρήστη.
```
![Dice5](https://user-images.githubusercontent.com/52785685/101353315-0d0de480-389c-11eb-948c-99a0344ff9c7.png)
<br>
```
Εικόνα 6 Λίστα των σκορ των χρηστών.
```
![Dice6](https://user-images.githubusercontent.com/52785685/101353346-1ac36a00-389c-11eb-9a64-5995af469e50.png)
<br>
```
Εικόνα 7 Πληροφορίες για το παιχνίδι που παρέχονται στον χρήστη.
```
![Dice7](https://user-images.githubusercontent.com/52785685/101353378-2747c280-389c-11eb-8589-d7eba4639c49.png)
