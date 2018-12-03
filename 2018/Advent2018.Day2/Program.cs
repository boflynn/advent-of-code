﻿using System;
using System.Linq;

namespace Advent2018.Day2
{
    class Program
    {
        #region Input
        private static readonly string input = @"efmyhuxcqqldtwjzvisepargvo
efuyhuxckqldtwjrvrsbpargno
efmyhuxckqlxtwjxvisbpargoo
efmyhuxczqbdtwjzvisbpargjo
efmyhugckqldtwjzvisfpargnq
tfmyhuxckqljtwjzvisbpargko
efmyhuxckqldtvuzvisbpavgno
efmyhufcrqldtwjzvishpargno
tfmyhuxbkqlduwjzvisbpargno
efayhtxckqldbwjzvisbpargno
efgyhuxckuldtwjzvisbpardno
efmyhuxckuldtwizvisbpargqo
efmyhuxcknldtjjzvihbpargno
efmyhuxcnqddtwjzvisbpafgno
efmyhubokqldtwjzvisbpargdo
efmhhuxckqldtwdzvisbpjrgno
efmyhuxckqldtwjrcisbpargny
efmyhuxckqsdtwjzlisbpargng
effyhuxckqlqtwjzjisbpargno
nfmyhjxckqldtwjzcisbpargno
efmyhvxckqldtwszvwsbpargno
efmyhuxckqldtwutvisbpprgno
kfmyhuxckqldtwzuvisbpargno
efhyhtxckqldtwjmvisbpargno
efmyhuhckqldtwjzvisbpxwgno
efmyhuxcfqldtrjzvitbpargno
efmyhudckqldtwjfvisbparvno
ekmyhuxckqlstwjzvisbdargno
efmyhuxckqlxtwjftisbpargno
etsyhuxckqldtwjzvisbpargnf
exmyhusckqldtwjzvisbpakgno
efmyhubckqlrtljzvisbpargno
efmyhuxckwldtwjovizbpargno
efmyhulckqzdtwjzvisbpargpo
efmyhuxckbcdlwjzvisbpargno
zfmyhulckqbdtwjzvisbpargno
efmyquxckfldtwazvisbpargno
efxyhuxakqldtwjzvisupargno
efmlhuxckkedtwjzvisbpargno
efhyhuxwkqldtwjzvisbparjno
efmyhuxfkqldtwjzvisvparyno
efmyhuxckqfdtijzvisblargno
efmyhuxckqldtfjzvisbwhrgno
efmymuxcknldtwzzvisbpargno
eomybuxckqldtwkzvisbpargno
pfmyhuxckqldtwgzvasbpargno
vfmyhuxcoqldtwjzvisbparvno
eflyhuxckqldtwjzvirypargno
efmyvuxckqldtwizvisbpaqgno
epmyhuxckqldtwjzvesbparpno
efoyhuxckoldtwjmvisbpargno
efmyhuxckqydtwpzvisbpaqgno
efmyhuxckqldezbzvisbpargno
efmyhuxckqldtwjzvisboalxno
efmyhuxckqldtwuzvipbjargno
efmymuxcuqldtwjzvasbpargno
jfmyhuxckqldtwjzvzsbpargdo
nfmyhuxckqlntsjzvisbpargno
efmxhuxckqgdtwjzvisbparjno
efmyhuxckpldtpjzvpsbpargno
efmyhuxcyqldtwjhvisbpargqo
efmyhexgkqydtwjzvisbpargno
ffmyhuxckqldtwjzvisbpafgnk
efmyfuxckqldtwjpvisbpartno
efmyhoxckcmdtwjzvisbpargno
efmyhuxxkqldtwjzviabparyno
jfmyhuxakqldtwgzvisbpargno
efmjhuxckqcdtwjzvisbjargno
efmyhuxccqldtwjzxisbxargno
efmyhurckqldiwjzvrsbpargno
efmyhuxckasdtwjzvisboargno
efmyhvxckmldtwjgvisbpargno
efmyhuxckoldtwjuvisbpardno
efmyduxckqldtwjgvzsbpargno
ejmyhuxckqldtwbzvisbpargnb
efmymuxchqldtwjzvibbpargno
efmyhjxckqldtwjgvinbpargno
efmyhuxhyqldtwbzvisbpargno
efmyhuxckqldtwjzvisbpzignq
efmyuueckqldxwjzvisbpargno
qfmyhyxckqldtwizvisbpargno
efmyhupckqldtwjzvpgbpargno
efmycuxckqldtwjzvfdbpargno
efmyhugcrqldtwjfvisbpargno
efmyhexckqldtwjzvischargno
efmyhuxckqldtljzvasbpamgno
efmyzdxckqldtwjovisbpargno
efmyhuxccqldtwjzvdsbpaigno
ufmyhuxekqldtwjzvisbpargne
efmyhuxckqldfwozvisgpargno
afmyhuackqldtwjzvisbdargno
efmyauxckqldtwjzvisiparmno
efmysuxckqldtwjzvisbeaggno
efmyhuxckqldtwjzvisbgzigno
efryhuxlkqldtwozvisbpargno
lfmyhuxckqldtwjzvhsbparuno
efmyhzxckqldswjzvisqpargno
efmyhuxrkqldtwjzvisgpargco
efmyhudckqldtwjzyisbkargno
efmyhuacqqldtwjzviabpargno
jfmyhuxckqldtwvzvicbpargno
efmkhuxckqlftejzvisbpargno
nfmyhuxckqldnwjzvisbxargno
efmyhuxckqldtwjvvisjpyrgno
efmyhuxcmxldtwjzvisbpargto
efmyhuxckqldtwqbvpsbpargno
efmyhuxckzldjwjzvisbplrgno
efmywgxckqldtwxzvisbpargno
efmsguxckqldhwjzvisbpargno
nfmyhuxlkqldtwjzvisbgargno
etmyhuxckqldtwjzvqsbptrgno
efmyxuxckqldtfjzvisbyargno
cfmihuxckqldtwjzvisbpargnf
jfzyhuxckqldtwjzviscpargno
efmyhuxckqldtmjzvisbpbzgno
bfmyhuzckqldcwjzvisbpargno
efmyhuxckqldtmjzvmslpargno
efqyvuxckqldtwazvisbpargno
efmecrxckqldtwjzvisbpargno
efmyhuuckqldtwjzvisrpargnt
efmphuxckqldtwjzvisbparmho
ifmyhuxckqldtwjzvismpsrgno
efmyhuookqldywjzvisbpargno
efmyhfxckyldtwjnvisbpargno
efmyhxhckqldtwjzvisqpargno
efryhuxcfqldtwjzvisbparkno
efmyhutckqldpwjzvixbpargno
efmyoukckqldtwjzvisbpargko
efmyhuxckqldtwjzviseparynv
efmyhuxcksldvwjzvisbnargno
efmyhuxckqrdtwlzmisbpargno
efmyhuxcwqldtwjzviqapargno
eymyhuxckqrdtwkzvisbpargno
efmyhuxckqldtwjzpisopargnj
efmyhuxikqldtwjzvirupargno
efmyhuxcuzldtnjzvisbpargno
efmyhxxikqldtwjzvisbpalgno
efmyhuxceqldtwjzvdsbparguo
efmyhuxwkqldtwjmvisbparxno
efmyhuxpkqldtwjzvisfpargfo
efmyfuxckaldtwjzvirbpargno
efmyhuxckqrdtwjzvismprrgno
efmyhuxckqldzwjzvisbpnrgfo
efmyhfuckqldtwjyvisipargno
efmyhuxcpqlqfwjzvisbpargno
efmyyuxckqldtwjzvrsepargno
efmphuxckqlptqjzvisbpargno
efmyhuxnfqldtwjzvisbpmrgno
efmyhuxckqldtwjzkisnpnrgno
mfmyhuxckqldtwjzvisbzarcno
efmyhuxckqldtwlzviszpargwo
efmytuxckqndtwjqvisbpargno
efmyzuxckqldtwjzvisbaargjo
efmihuxckqlutwjzvimbpargno
efmyhuxckqldgwjzvixbparono
tfmyduxckqldtyjzvisbpargno
ejmyhuockqldtwjzvidbpargno
efmyheyckqkdtwjzvisbpargno
efmyhuxckqldtwjzoisbpargfj
efqyhuxcxqldtwxzvisbpargno
jfmyhaxckqldtwjzvisbvargno
hfmyhqxckqldtwjzvisbparvno
efmyhukckqlrtwjzvqsbpargno
efmyhuxckqldvwmzvisbparrno
efoyhuxckqldtwjzvilwpargno
ejmyhuxckqldtwjzxisbprrgno
efmyhuxckqldtsjzvisupdrgno
efzyhjxckqldtwjzvisbpasgno
ebmyhulckqldtwjzvisbpargnr
efmyhuxcjqlntwjzqisbpargno
efmlocxckqldtwjzvisbpargno
efmyhuxckqldtwjzvizkpargnm
ebmyhuxckqldtwjzvlfbpargno
efmyhuxckqldtwjyvisbpjrgnq
afmyhuxckqldtwjzvpsbpargnv
efmyxuxckqwdzwjzvisbpargno
efmyhuxskqlqthjzvisbpargno
efmyhuxckqldtwdzvisbearglo
mfmyhuxckqldtzjzvisbparggo
efmyhuqckqodtwjzvisbpadgno
efmyhuxctqldywjzvisspargno
efmyhuxckqqdtwjnvisbporgno
efmyhixckqldowjzvisbpaagno
efmyhuxckqldtsszvisbpargns
edmyhuxckqpdtwjzrisbpargno
efsyhuxckqldtijzvisbparano
efmyhuxckqxdzwjzviqbpargno
efmyhuxckqldtwjzviqqpsrgno
efmyhuockqlatwjzvisbpargho
efmyhuxckqldtwjzvishkavgno
vfmyhuxckqldtwjzvksbaargno
efmahuxckqudtwbzvisbpargno
ewmyhixckqudtwjzvisbpargno
efmywuxczqldtwjzvisbpargao
efmyhuqjkqldtwyzvisbpargno
efmyhuxekqldtwjzmksbpargno
efmyhuxcoqtdtwjzvinbpargno
ebmyhuxkkqldtwjzvisbdargno
ecmyhnxckqldtwnzvisbpargno
efmyhuxbkqldtwjzvksbpaigno
efayhuxckqidtwjzvisbpavgno
efmrhuxckqldswjzvisbpaugno
efmyhuuckqldtwjyvisipargno
xfmyhuxckqldawjzvosbpargno
efmyhuxckklhtwjzvisbpargnq
efmyhmxcaqldzwjzvisbpargno
efiyhuxcksldtwjzvisbpamgno
zfmyhuzckqldtwjzvisbparhno
efmyhuxckqlvtwjdvisbparsno
efmyhmxckaldtwjzmisbpargno
efmysuxcqoldtwjzvisbpargno
efmyhuxckqldtwjzvisbsargrb
effyhuxckqldtwjzvisbpwfgno
efmyhuxclqmdtwjzxisbpargno
edmohuxckqldtwjziisbpargno
efmyhuxckpldtwjzviubpaegno
efmyhuxcpqldtwjzjimbpargno
ehmyhuxckqldtwjzsisbpargnq
efmyhcxcdqldtwjzvisbqargno
efmjhuxckqldmwjzviybpargno
efeyhzxckqlxtwjzvisbpargno
efmyhuxczqadtwazvisbpargno
efmahuxckqldtwjzvisbpafgnl
efmyouxckqldtwjzvizbpacgno
emmrhuxckqldtwjzvisqpargno
exmyhuxckqlftwjnvisbpargno
efuyhuxckqldrwjzvisbpargnw
efmywuxfkqldtwjztisbpargno
efmyhuxdkqldtwjzvisbpqrzno
eemyhuxckqldrwjzvisbpajgno
efmyiuxckqldtbjzvrsbpargno
eqmyhuxckqldlwjzfisbpargno
efmyhuxckqlitwuzvisbpvrgno
ecoyhuxckqldtwjzvishpargno
efmyhuxckcldtwjzlisbparlno
efmyhsxcknldtwjfvisbpargno
efmyhuxckqldtwjrvosbpargbo
enmehuxckzldtwjzvisbpargno
hfmyhuxckqqdtwjzvisbpawgno
efmyhufckcjdtwjzvisbpargno
efmxhuxckqldthjzvisfpargno
efmyaukckqldtwjsvisbpargno
efmyhukckqldtwpzvisbpmrgno
dfmyhuxckqldtwjzvisbvarmno
afmbhuxckqldtwjzvssbpargno
efmyhuxchqldtwezvisbpargzo
efmphuxckqlxjwjzvisbpargno
efhyxuxckqldtwjzvisbpargko
sfmyhexckqldtwjzvisbqargno
efmghuxckqldtwjzvitbparnno";
        #endregion
        static void Main(string[] args)
        {
            // Part1();

            Part2();
        }

        private static void Part1()
        {
            var inputs = input.Split('\n');

            var characterInputs = inputs.Select(i => i.ToCharArray().GroupBy(c => c));

            var twos = characterInputs.Count(g => g.Any(gg => gg.Count() == 2));
            var threes = characterInputs.Count(g => g.Any(gg => gg.Count() == 3));

            Console.WriteLine(twos * threes);
        }

        private static void Part2()
        {
            var inputs = input.Split('\n').Select(i => i.Trim()).ToList();
            var inputsLength = inputs.Count;
            var wordLength = inputs[0].Length;

            for (var i = 0; i < inputsLength; ++i)
            {
                for (var j = i + 1; j < inputsLength; ++j)
                {
                    var left = inputs[i];
                    var right = inputs[j];
                    var commonWord = string.Empty;

                    for (var l = 0; l < wordLength; ++l)
                    {
                        if (left[l] == right[l])
                        {
                            commonWord += left[l];
                        }
                    }

                    if (commonWord.Length == wordLength - 1)
                    {
                        System.Console.WriteLine(commonWord);
                        return;
                    }
                }
            }

        }
    }
}
