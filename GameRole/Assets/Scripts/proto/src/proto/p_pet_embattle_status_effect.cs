namespace proto {
	public class p_pet_embattle_status_effect : Message
	{
		public int pos = 0;
		public int poison_round = 0;
		public int burning_round = 0;
		public int dizzy_round = 0;
		public int freeze_round = 0;
		public int immune_round = 0;
		public p_pet_embattle_status_effect() {
		}
		public override string getClassName() {
			return "p_pet_embattle_status_effect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pos", "int", "null"},new string[] {"poison_round", "int", "null"},new string[] {"burning_round", "int", "null"},new string[] {"dizzy_round", "int", "null"},new string[] {"freeze_round", "int", "null"},new string[] {"immune_round", "int", "null"}};
		}
	}
}
