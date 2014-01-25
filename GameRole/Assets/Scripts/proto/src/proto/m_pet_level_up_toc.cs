namespace proto {
	public class m_pet_level_up_toc : Message
	{
		public p_pet pet_info = null;
		public m_pet_level_up_toc() {
		}
		public override string getMethodName() {
			return "pet_level_up";
		}
		public override string getClassName() {
			return "m_pet_level_up_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_info", "p_pet", "null"}};
		}
	}
}
