/* OPAS HARJOITUKSEN TEKEMISEEN:
 * 
 * Kaikki "kauttaviiva"+"tähti" -yhdistelmän ja "tähti"+"kauttaviiva" välissä on kommenttia.
 * Sitä ei siis suoriteta, vaan se on sinun, eli harjoituksen tekijän ohjeeksi.
 * 
 * Aloita kohdasta 1., joka on Begin()-aliohjelmassa alla (rivi 35). 
 *  Tee harjoitus kirjoittamalla kohdan kommenteissa olevan ohjeen mukainen ohjelmakoodi 
 *  (rivi tai kaksi) kommentin, eli "tähti"+"kauttaviiva" -yhdistelmän jälkeen.
 *  
 * Jos joku on epäselvää, kysy ohjaajalta apua. Valmis ohjelmakoodi on lisäksi nähtävissä
 * ruudun oikean laidan "VihaisetLinnutValmis.cs" -tiedostossa (tuplaklikkaa nähdäksesi sen). 
 * Myös kirjaston käyttöohjeet saattavat auttaa:
 * https://trac.cc.jyu.fi/projects/npo/wiki/KirjastonOhjeet
 */

using System;
using System.Collections.Generic;
using Jypeli;
using Jypeli.Assets;
using Jypeli.Controls;
using Jypeli.Effects;
using Jypeli.Widgets;

public class VihaisetLinnut : PhysicsGame
{
    /* // 7. Tee muuttujista lintu ja possu luokkamuuttujia, jolloin ne ovat käytettävissä
     * //  kaikissa aliohjelmissa esittelemällä ne jo tässä:
     *  
     * PhysicsObject <muuttuja>;
     * 
     * // Poista "PhysicsObject" muuttujan nimen edestä Begin()-aliohjelmassa, jotta sielläkin
     * //  tiedetään käyttää tätä uutta luokkamuuttujaa (eikä aliohjelmamuuttujaa).
     * // Tee seuraavaksi kohta 8. (tiedoston loppupuolella)
     * 
     */ // KIRJOITA KOHDAN 7. KOODI TÄMÄN RIVIN ALLE //
         

    public override void Begin()
    {
        /* /////////////////////////////////////////
         * // ALOITA HARJOITUKSEN TEKEMINEN TÄSTÄ //
         * /////////////////////////////////////////
         * 
         * // 1. Lisää "lintu" peliin luomalla uusi peliolion tämän kommenttiblokin jälkeen.
         * //  Uusi peliolio lisätään seuraavasti:
         * 
         * PhysicsObject muuttujanNimi = new PhysicsObject(<leveys>, <korkeus>, <muoto>);
         * 
         * // missä <leveys> ja <korkeus> ovat kokonaislukuja ja <muoto> on Shape.<jotain>
         * // HAKASULUISSA OLEVAN TILALLE SIIS KIRJOITAT JOTAIN (ILMAN HAKASULKUJA)
         * // PhysicsObject noudattelee fysiikan lakeja. Sitten:
         * 
         *  Add(muuttujanNimi);
         *  
         *  // Add lisää muuttujassa olevan peliolion peliin.
         *  // Paina [F5], joka kääntää ja ajaa pelin. Peli lopetetaan painamalla [Esc].
         *  
         */ // KIRJOITA KOHDAN 1. KOODI TÄMÄN RIVIN ALLE //


        /* // 2. Kokeile muuttaa linnun ominaisuuksia:
         * 
         * lintu.X = <kokonaisluku>;
         * lintu.Y = <kokonaisluku>;
         * lintu.Color = Color.<jotain>;
         * 
         */ // KIRJOITA KOHDAN 2. KOODI TÄMÄN RIVIN ALLE


        /* // 3. Lisää possu. Katso 1. kohdan linnun lisäyksestä mallia.
         * 
         */ // KIRJOITA KOHDAN 3. KOODI TÄMÄN RIVIN ALLE //
        

        /* // 4. Lisää maa: 
         * 
         * Level.CreateBottomBorder();
         *  
         * // ja painovoima:
         * 
         * Gravity = new Vector(<x-suunnassa>, <y-suunnassa>);
         * 
         */ // KIRJOITA KOHDAN 4. KOODI TÄMÄN RIVIN ALLE //
        

        /* // 5. Sovella kohdissa 1 ja 3 oppimaasi ja lisää kolme palikkaa, jotka muodostavat possun "linnan"
         * //  asemoi palikat yritys-erehdys menetelmällä. Muista, että [F5] joka kääntää ja ajaa pelin.
         * 
         */ // KIRJOITA KOHDAN 5. KOODI TÄMÄN RIVIN ALLE //
        

        /* // 6. Laitetaan hiiren osoitin näkyviin ja kuunnellaan hiiren naksautusta:
         * 
         * IsMouseVisible = true;
         * Mouse.Listen(MouseButton.Left, ButtonState.Released, AmmuLintu, "Ammu lintu hiirellä");
         * 
         * // Tässä AmmuLintu on aliohjelma, joka kirjoitetaan kohdassa 8.
         * // Tee seuraavaaksi kohta 7 (ihan tiedoston alussa)
         * 
         */ // KIRJOITA KOHDAN 6. KOODI TÄMÄN RIVIN ALLE //
         

        Keyboard.Listen(Key.Escape, ButtonState.Pressed, ConfirmExit, "Lopeta peli");

        /* // 9. Kerromme vielä pelille, että olemme kiinnostuneita tietämään koska possuun osuu (törmäyksiä)
         * //  kirjoittamalla rivin:
         * AddCollisionHandler(possu, PossuunOsuu);
         */ // KIRJOITA KOHDAN 9. KOODI TÄMÄN RIVIN ALLE //


    }


    /* // 8. Teemme uuden aliohjelman: "AmmuLintu"
     * // Aliohjelmat ovat muotoa
     * 
     * void <AliohjelmanNimi>() {...}
     * 
     * // missä kolmen pisteen tilalle tulee aliohjelman
     * //  toteutus, eli se mitä tehdään kun aliohjelmaa kutsutaan. 
     * // 
     * // Käytä aliohjelmassa lintu-PhysicsObjektin toimintoa:
     * 
     * lintu.Hit(<Suuntavektori>);
     * 
     * // joka siis lyö linta suuntavektorin suuntaan. 
     * 
     * // VINKKI:
     * 
     * Mouse.PositionOnScreen
     * 
     * // on vektori, joka kertoo hiiren osoittimen sijainnin.
     * 
     * lintu.Position 
     * 
     * // on vektori, joka kertoo linnun sijainnin.
     * // Vektoreilla voi tehdä aritmetikkaa ja niitä voi kertoa skalaarilla.
     * // Laske siis <Suuntavektori>, joka osoittaa mihin suuntaan lyödään (ja kunka kovaa)
     * 
     * // Siirry Begin()-aliohjelman loppuun ja tehtävän kohtaan 9.
     * 
     */ // KIRJOITA KOHDAN 8. KOODI TÄMÄN RIVIN ALLE //


    /* // 10. Tee uusi aliohjelma "PossuunOsuu". Katso mallia kohdasta 8.
     * //  Kirjoita tällä ketaa kuitenkin aliohjelman esittelyyn kaarisulkeiden 
     * //  sisään kaksi parametria: PhysicsObject tormaaja, PhysicsObject kohde
     * 
     * // Kirjoita nyt aliohjelman kaarisulkeiden väliin aliohjelman logiikka.
     * //  Siinä tervitset tietoa, että PhysicsObject-oliolla on ominaisuus
     * //  <olio>.Velocity.Magnitude, joka siis on desimaaliluku ja edustaa liikenopeutta.
     * // 
     * // Jos törmääjä tai törmäyksen kohde liikkuu tarpeeksi nopeasti,
     * //  tuhoa possu kutsumalla
     * 
     * possu.Destroy();
     * 
     * // Käytä tähän if -ehtoa (rakennealla) tarkistamaan, että jos tormaajan tai kohteen
     * //  nopeus on suurempi kuin joku sopiva kokonaisluku:
     * 
     * if (<nopeus> > <joku_luku>)
     * {
     *     possu.Destroy();
     * }
     * 
     * // Tarvitset näitä tarkistuksia kaksi.
     *
     * // Viimeistään nyt paina [F5] ja nauti valmiista pelistä.
     * 
     */
    // KIRJOITA KOHDAN 10. KOODI TÄMÄN RIVIN ALLE //

}
