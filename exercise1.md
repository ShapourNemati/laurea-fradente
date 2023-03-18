# Exercise 1

__Ciao, stiamo per andare in produzione, ma ci siamo accorti che nel creare i token di auth non inseriamo i claim standard di openiddict. Ti lascio qui un esempio dalla doc di OIDC, riesci a farmi una classe che lo rappresenti? Ovviamente con gli standard di C#, vanno bene tutte proprietà pubbliche, mi raccomando il PascalCase, e se ti va pure getter e setter standard. Salva il file come `Person.cs` all'interno della directory `brotooth.alwayspresent/`.__

Appena lascerai questo file, partirà il tempo.
Hai 1 minuto.
L'esercizio sarà considerato valido se completato entro il tempo e senza errori di compilazione né warning.

// {
//   "name": "John Doe",
//   "nickname": "john.doe",
//   "picture": "https://myawesomeavatar.com/avatar.png",
//   "updated_at": "2017-03-30T15:13:40.474Z",
//   "email": "john.doe@test.com",
//   "email_verified": false,
//   "iss": "https://{yourDomain}/",
//   "sub": "auth0|USER-ID",
//   "aud": "{yourClientId}",
//   "exp": 1490922820,
//   "iat": 1490886820,
//   "nonce": "crypto-value",
//   "at_hash": "IoS3ZGppJKUn3Bta_LgE2A"
// }