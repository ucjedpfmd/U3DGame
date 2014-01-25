namespace proto {
	public class m_pet_tower_end_toc : Message
	{
		public int err_code = 0;
		public m_pet_tower_end_toc() {
		}
		public override string getMethodName() {
			return "pet_tower_end";
		}
		public override string getClassName() {
			return "m_pet_tower_end_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"err_code", "int", "null"}};
		}
	}
}
