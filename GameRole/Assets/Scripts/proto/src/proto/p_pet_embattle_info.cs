namespace proto {
	public class p_pet_embattle_info : Message
	{
		public int embattle_pos = 0;
		public int embattle_skill = 0;
		public p_pet_embattle_info() {
		}
		public override string getClassName() {
			return "p_pet_embattle_info";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"embattle_pos", "int", "null"},new string[] {"embattle_skill", "int", "null"}};
		}
	}
}
