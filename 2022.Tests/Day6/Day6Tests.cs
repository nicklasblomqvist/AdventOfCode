using AdventOfCode2022.Day6;
using FluentAssertions;

namespace AdventOfCode2022.Tests.Day6
{
    public class Day6Tests
    {
        readonly IDay6 sut = new Day6ListImplementation();

        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        [Fact]
        public void ShouldHandleFirstExample()
        {
            // Arrange
            var input = "bvwbjplbgvbhsrlpgdmjqwftvncz";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 4);

            // Assert
            firstPosition.Should().Be(5);
        }

        [Fact]
        public void ShouldHandleSecondExample()
        {
            // Arrange
            var input = "nppdvjthqldpwncqszvftbrmjlhg";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 4);

            // Assert
            firstPosition.Should().Be(6);
        }

        [Fact]
        public void ShouldHandleThirdExample()
        {
            // Arrange
            var input = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 4);

            // Assert
            firstPosition.Should().Be(10);
        }

        [Fact]
        public void ShouldHandleFourthExample()
        {
            // Arrange
            var input = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 4);

            // Assert
            firstPosition.Should().Be(11);
        }

        [Fact]
        public void ShouldHandlePuzzle()
        {
            // Arrange
            var input = "qzbzwwghwhwdhdqhhbhfbfsstggdsssgzgdzzdbbbzmbzzvlldppjnjlltwtsszwswgssjnsjnnfqfzqqjzjfjmfmwfmfhfnnmdnmnllbzzlbzlzflldzdbzbsbdddpgdppzhphhjjtccjgcgrgjgcjgjjsbjbffsgsqqrsqqgppgmgcmmrdrqdqbqmmctchcgcdgdwdwcdcjcfjccmpmlpllqqpmpllhfhchppwwdmdhdphpvprrhwhgwwlrwlwggwlwqqnmqnqrrbbzdzwddqzznllzwlljsscqqtlltppqspswsttlrttnvvvwllfslsjsfjssnqnbbbvgvlltjtltjljmljjfgfbggcbgbmbjjvwjvjgvgzvvzddrjdddrwrlrlgldlhlwwcddbsbbtwwcssrnndvvsbsnbsbmbnmngnpgpphfhzhshllltqtppnrrzpzrpzzrttmbmssbrbmbsmsnspnsncscwwmjwmwdmwmrmvmqvqvjqvvnrrtntwwwwsrwrnwnrwwwlslrlhrllvpvhppdpprrgzrgzggqmqgmgvghhsmhhjljfflrflfrlrzzbjjqmmmcncddvhhzjjqzzjfzzbssjqqtsqtqccmttdhttmwtmtffspplhlrhrdhhhpghgrhrchhmgmqgqlglssvnnwrrrrqqbmmpgmpmdmmljlflzzjttqntqqcnqccrvcczffclffmvfvwvmvnvsvnvffczzljzztdtztcztctbtppmrprqprpbbhlhphphhvppvdvmddvcctvvjbvvpmpbpnpllvclvlqlwqqpcpffdwdsdttzftfddbrrgsrgsgvgpgjpggfvgfvvtqtnnscssmnnfqnnblnnjlnlbbjrrmmpgmgnnqbbcjbcjbbmjjljsjrsjrsrwrgwgpgqgccqppfdpdssffgdgwddcvdvzzpttjlttmwwhnnlntncttfvfwvvwrvrwwlhlwlvwvzvpvfpvvsbslblrlssjddwhwfhwffqjfjzfjfmfrrvsrrlbrrdfdmdwmddpnpfnpfnfppczpprzprpvpjjtltptvvrgvvsttflfvfqqhnnbmnbmmpsptpdpttrbbhjbbdnntppbsbmssgccfdfflppbcpbblclrlhrhttffvqqvvnpnmpnnrbnnhqnqrrwvwrrbvbffcvctcjcwwmzmvvtdvtvbtblbvlbvlvdvdrdsrdrprllnzznzhhcjjsgglfglgrlrwwfcfzfjzfztfztzggffjftjffcbfbhhwfwnnbssrpsppmllszstztwwgbwgbgtbgggztgztzwtztbbrffznndhdmmqggssjfssrgssbnsndnqnvqvqvjqvqttlctltvlttrzrqrrdprddpqqvppvddgmdddpldllnvvjdjcjdjvvznzqqbgqbgbpbnbvvdjvvsnndsdjjjhnhggrnnrvrvlvqllqhhsbhssvvlhlssgqgmqqcscpsspsrpsrpspvvdmvdvwwcjwwvhwvvmzvzvfvccfzczjccscbcrcjrrrsgrsspnsntsnnrnwwhdwwzhzbbwgwcgglvlttqrttvrrgprrljlddnttqrqffgdfgdgzzhghthhmdmsmtsshhsfhhgzgvzgzwzffvlffzjjrttsdddbldljlvjvjttwdwzzrbblwbbgmbmgmbggbdbsbqqwzzgnzgzczpzfztftbtwbtbsttrwrfrssbrrdqdjqdqppdsswrwttmgmllqbqnnpspjjzjjmbbsddgjgbjggqqlgqgmgdmmwcmwcmwwsddvgvpphmhqmmlvlpvlpltllphhcshhrsrgsgzssspjspplgghvvwhwgwssbhshvvscshhbccbtcbcvvmnndsdwwbzbffhmmbppfjppbsblbtlltggzczdczdzjdjpjtppwdwlwqwnwjnnvttmcmzzqccvfcvvmrmzmwmhmttgdgmsrlddnbgqfbbmrpdglpbtdqpmctzjrffvvqnltcqlfddwqhvjpzhczzwhsmjtrpgsdtqlcqsljsjzqwhcfwttgghsjqhzqlgjzgrtgttwblpprbppcpzsbntrwwmvfvbmjjrjwjqcjhnstmvwzrbnjpzznnctrtllzhtwttntjqwjnfspzccqpjlzbncgbjjjztbgfmzflzsqflflcrfhtlsgbdfdbtwwqfdrqhzmmqdqthwzwqqqzddfvbwhnqwqtgwhtzlqqpwhcjhglcmmncvfcmqdwnzzmjbflwjrcjzwcblftzrpdcjzcmtzccjbsqmcnfmbsmrvlhswnmrqdczvvzzcnffgljdbtlvjgrqttcjhjmcdllnvhcdpztqghfgvjcqmqvmdwhcgrtwpjlmjfbqmnjnbvvjczcwfcrhcgzmsvmjlplcpghnqtpzddnwtmrwmqwbttsnlngszfbnslqvlbzbfzqnjpdvcdpmjpmmjhvzwwgzfjfqwbqwrznhsdpjgsvzlsrtlmhjrfnwrmljlqzwnfnsmqtzfsldwrgmbrrvcmmmdmwflwnvpwsrrstmffwbtwqmjzdnzbwmqfrfdgsmhzhprdsgsqtljqhtdqmvnzlwhrrqqftbvnhmjnzvmbdqpjhzjnszgcfptfcmthpfcvfvdmwdswzfgwjblglfbpfvvwrmnzlcvtgqbcrhfqlffrznnhbtbwdwdldthbhdsqvnghpqdlvpfmzhjbtdhfmrdzpghtppmvddnphcnnczvznwzrvtcwvpslhrhmhzbzqtjqjvdpwncjbqdnwwpnfblqtqdwwqncbvtsncfhgncrprvhvzppwjfpdmtdrmtfcqdmdhwzrhpnrvspfbzhsvlpwzgrrhnrllhmpcdfcqdhcnphlffpbfmbsznmvfdgshbsjcjjvhqqfpmjgpdpcrglbqdrnqmftqtnwcsgqzdwntfplsnlhdbdmcgwfldzzgmzjsdnldbnlnhjqhpmnsljsbhrglhjbbrmlhrmjnvzhnlvnfpdzfzwwdpzwhnqhlbqhrgfmvzpctdvscqbgznzdsvvvvcjnmbzlvsptslmqnggqjcmgvtgbnrzlmzqzmtdfvhjqqcpvbngmngjvrtcfvsmbvthvhmdcfhthmnjcvsvmsbwsjtmrwshspcsmnhvzqvglntngbmgtdngbvvcjrznpdmmsssljnnqjwwfzgwtlfqqpsqghjgrghldrcdmcqvqdjsfrfrnlnvltpfjhmcclwbsdcbmvmlnwltztfggzmrtnsczwvqgpqtwffmphprgrmjlnftlgqjvrngbcndlmrblmvcjsdhdcmtgsztjttpbgcznfcgdwfwdnqmrrjgdgrgshjfjqrbsjdhblvrqhlfphnbdslrjszcnpfhhwrfhhdvqbjpsmzznzbtbsgcggtctfbsrscvzlplfhlwjlrmzhbwjqhffdhrwcdctwvttwqzbdtrhdhdvtgvdbzjtqvdgbpwtzqqqnljztgpbjjcrgdgmrrsfvngcdbgzvcfpdppbgfrmmdnqdvtlwwglmghjwfjjrwjfnwgwdplbmlfljhsmshwvvvtdnvfcbbwplwnvzfcjwgsrrlctpsrhprttcjgcmfsjggfvbbljsbjtzplvjdwnwgsgvvntjwdwdqbwmtnnlgdcmfcccnwnrjlqtznjhdzwfpbzhjdmwwpcmffcwsnpfhmgqgwwnvpmqvrdfhlqtghrrbggdmtvpqgqsspmchnrqnrmqlddnspcdrwqpvclhrvjtzhpvthpltwqqbrdfjtnwncwrmdqszdpmmdzmjwjvqnfszvbchfdvwzhtrfgfhfmgwprdpqgmbfntsqztvqmtjvgbsjvzsbhfznbbzrstqbrrmqdjcztmfpnwbmvtccmvlhtvmgfdzcchbccrzznscbdwrdtnpslvcqmgrrvwhnjgjdpvbfgsdtdcmhpnwfwnnntqjqnwzfwnhsrjbhtqtlncvsnhgvtntfwldqfzztcdctsscfdmtnmdqgqgwmtqhlmswtqrvqbchdwtjsdlqjvfjdtmzlvrzwvfprzvjzrrfn";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 4);

            // Assert
            firstPosition.Should().Be(1987);
        }

        [Fact]
        public void ShouldHandlePart2FirstExample()
        {
            // Arrange
            var input = "mjqjpqmgbljsphdztnvjfqwrcgsmlb";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(19);
        }

        [Fact]
        public void ShouldHandlePart2SecondExample()
        {
            // Arrange
            var input = "bvwbjplbgvbhsrlpgdmjqwftvncz";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(23);
        }

        [Fact]
        public void ShouldHandlePart2ThirdExample()
        {
            // Arrange
            var input = "nppdvjthqldpwncqszvftbrmjlhg";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(23);
        }

        [Fact]
        public void ShouldHandlePart2FourthExample()
        {
            // Arrange
            var input = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(29);
        }

        [Fact]
        public void ShouldHandlePart2FifthExample()
        {
            // Arrange
            var input = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(26);
        }

        [Fact]
        public void ShouldHandlePart2Puzzle()
        {
            // Arrange
            var input = "qzbzwwghwhwdhdqhhbhfbfsstggdsssgzgdzzdbbbzmbzzvlldppjnjlltwtsszwswgssjnsjnnfqfzqqjzjfjmfmwfmfhfnnmdnmnllbzzlbzlzflldzdbzbsbdddpgdppzhphhjjtccjgcgrgjgcjgjjsbjbffsgsqqrsqqgppgmgcmmrdrqdqbqmmctchcgcdgdwdwcdcjcfjccmpmlpllqqpmpllhfhchppwwdmdhdphpvprrhwhgwwlrwlwggwlwqqnmqnqrrbbzdzwddqzznllzwlljsscqqtlltppqspswsttlrttnvvvwllfslsjsfjssnqnbbbvgvlltjtltjljmljjfgfbggcbgbmbjjvwjvjgvgzvvzddrjdddrwrlrlgldlhlwwcddbsbbtwwcssrnndvvsbsnbsbmbnmngnpgpphfhzhshllltqtppnrrzpzrpzzrttmbmssbrbmbsmsnspnsncscwwmjwmwdmwmrmvmqvqvjqvvnrrtntwwwwsrwrnwnrwwwlslrlhrllvpvhppdpprrgzrgzggqmqgmgvghhsmhhjljfflrflfrlrzzbjjqmmmcncddvhhzjjqzzjfzzbssjqqtsqtqccmttdhttmwtmtffspplhlrhrdhhhpghgrhrchhmgmqgqlglssvnnwrrrrqqbmmpgmpmdmmljlflzzjttqntqqcnqccrvcczffclffmvfvwvmvnvsvnvffczzljzztdtztcztctbtppmrprqprpbbhlhphphhvppvdvmddvcctvvjbvvpmpbpnpllvclvlqlwqqpcpffdwdsdttzftfddbrrgsrgsgvgpgjpggfvgfvvtqtnnscssmnnfqnnblnnjlnlbbjrrmmpgmgnnqbbcjbcjbbmjjljsjrsjrsrwrgwgpgqgccqppfdpdssffgdgwddcvdvzzpttjlttmwwhnnlntncttfvfwvvwrvrwwlhlwlvwvzvpvfpvvsbslblrlssjddwhwfhwffqjfjzfjfmfrrvsrrlbrrdfdmdwmddpnpfnpfnfppczpprzprpvpjjtltptvvrgvvsttflfvfqqhnnbmnbmmpsptpdpttrbbhjbbdnntppbsbmssgccfdfflppbcpbblclrlhrhttffvqqvvnpnmpnnrbnnhqnqrrwvwrrbvbffcvctcjcwwmzmvvtdvtvbtblbvlbvlvdvdrdsrdrprllnzznzhhcjjsgglfglgrlrwwfcfzfjzfztfztzggffjftjffcbfbhhwfwnnbssrpsppmllszstztwwgbwgbgtbgggztgztzwtztbbrffznndhdmmqggssjfssrgssbnsndnqnvqvqvjqvqttlctltvlttrzrqrrdprddpqqvppvddgmdddpldllnvvjdjcjdjvvznzqqbgqbgbpbnbvvdjvvsnndsdjjjhnhggrnnrvrvlvqllqhhsbhssvvlhlssgqgmqqcscpsspsrpsrpspvvdmvdvwwcjwwvhwvvmzvzvfvccfzczjccscbcrcjrrrsgrsspnsntsnnrnwwhdwwzhzbbwgwcgglvlttqrttvrrgprrljlddnttqrqffgdfgdgzzhghthhmdmsmtsshhsfhhgzgvzgzwzffvlffzjjrttsdddbldljlvjvjttwdwzzrbblwbbgmbmgmbggbdbsbqqwzzgnzgzczpzfztftbtwbtbsttrwrfrssbrrdqdjqdqppdsswrwttmgmllqbqnnpspjjzjjmbbsddgjgbjggqqlgqgmgdmmwcmwcmwwsddvgvpphmhqmmlvlpvlpltllphhcshhrsrgsgzssspjspplgghvvwhwgwssbhshvvscshhbccbtcbcvvmnndsdwwbzbffhmmbppfjppbsblbtlltggzczdczdzjdjpjtppwdwlwqwnwjnnvttmcmzzqccvfcvvmrmzmwmhmttgdgmsrlddnbgqfbbmrpdglpbtdqpmctzjrffvvqnltcqlfddwqhvjpzhczzwhsmjtrpgsdtqlcqsljsjzqwhcfwttgghsjqhzqlgjzgrtgttwblpprbppcpzsbntrwwmvfvbmjjrjwjqcjhnstmvwzrbnjpzznnctrtllzhtwttntjqwjnfspzccqpjlzbncgbjjjztbgfmzflzsqflflcrfhtlsgbdfdbtwwqfdrqhzmmqdqthwzwqqqzddfvbwhnqwqtgwhtzlqqpwhcjhglcmmncvfcmqdwnzzmjbflwjrcjzwcblftzrpdcjzcmtzccjbsqmcnfmbsmrvlhswnmrqdczvvzzcnffgljdbtlvjgrqttcjhjmcdllnvhcdpztqghfgvjcqmqvmdwhcgrtwpjlmjfbqmnjnbvvjczcwfcrhcgzmsvmjlplcpghnqtpzddnwtmrwmqwbttsnlngszfbnslqvlbzbfzqnjpdvcdpmjpmmjhvzwwgzfjfqwbqwrznhsdpjgsvzlsrtlmhjrfnwrmljlqzwnfnsmqtzfsldwrgmbrrvcmmmdmwflwnvpwsrrstmffwbtwqmjzdnzbwmqfrfdgsmhzhprdsgsqtljqhtdqmvnzlwhrrqqftbvnhmjnzvmbdqpjhzjnszgcfptfcmthpfcvfvdmwdswzfgwjblglfbpfvvwrmnzlcvtgqbcrhfqlffrznnhbtbwdwdldthbhdsqvnghpqdlvpfmzhjbtdhfmrdzpghtppmvddnphcnnczvznwzrvtcwvpslhrhmhzbzqtjqjvdpwncjbqdnwwpnfblqtqdwwqncbvtsncfhgncrprvhvzppwjfpdmtdrmtfcqdmdhwzrhpnrvspfbzhsvlpwzgrrhnrllhmpcdfcqdhcnphlffpbfmbsznmvfdgshbsjcjjvhqqfpmjgpdpcrglbqdrnqmftqtnwcsgqzdwntfplsnlhdbdmcgwfldzzgmzjsdnldbnlnhjqhpmnsljsbhrglhjbbrmlhrmjnvzhnlvnfpdzfzwwdpzwhnqhlbqhrgfmvzpctdvscqbgznzdsvvvvcjnmbzlvsptslmqnggqjcmgvtgbnrzlmzqzmtdfvhjqqcpvbngmngjvrtcfvsmbvthvhmdcfhthmnjcvsvmsbwsjtmrwshspcsmnhvzqvglntngbmgtdngbvvcjrznpdmmsssljnnqjwwfzgwtlfqqpsqghjgrghldrcdmcqvqdjsfrfrnlnvltpfjhmcclwbsdcbmvmlnwltztfggzmrtnsczwvqgpqtwffmphprgrmjlnftlgqjvrngbcndlmrblmvcjsdhdcmtgsztjttpbgcznfcgdwfwdnqmrrjgdgrgshjfjqrbsjdhblvrqhlfphnbdslrjszcnpfhhwrfhhdvqbjpsmzznzbtbsgcggtctfbsrscvzlplfhlwjlrmzhbwjqhffdhrwcdctwvttwqzbdtrhdhdvtgvdbzjtqvdgbpwtzqqqnljztgpbjjcrgdgmrrsfvngcdbgzvcfpdppbgfrmmdnqdvtlwwglmghjwfjjrwjfnwgwdplbmlfljhsmshwvvvtdnvfcbbwplwnvzfcjwgsrrlctpsrhprttcjgcmfsjggfvbbljsbjtzplvjdwnwgsgvvntjwdwdqbwmtnnlgdcmfcccnwnrjlqtznjhdzwfpbzhjdmwwpcmffcwsnpfhmgqgwwnvpmqvrdfhlqtghrrbggdmtvpqgqsspmchnrqnrmqlddnspcdrwqpvclhrvjtzhpvthpltwqqbrdfjtnwncwrmdqszdpmmdzmjwjvqnfszvbchfdvwzhtrfgfhfmgwprdpqgmbfntsqztvqmtjvgbsjvzsbhfznbbzrstqbrrmqdjcztmfpnwbmvtccmvlhtvmgfdzcchbccrzznscbdwrdtnpslvcqmgrrvwhnjgjdpvbfgsdtdcmhpnwfwnnntqjqnwzfwnhsrjbhtqtlncvsnhgvtntfwldqfzztcdctsscfdmtnmdqgqgwmtqhlmswtqrvqbchdwtjsdlqjvfjdtmzlvrzwvfprzvjzrrfn";
            using var stream = GenerateStreamFromString(input);

            // Act
            var firstPosition = sut.GetStartPositionAfterUniqueSequence(stream, 14);

            // Assert
            firstPosition.Should().Be(3059);
        }
    }
}