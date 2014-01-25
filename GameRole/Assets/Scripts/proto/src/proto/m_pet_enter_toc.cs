namespace proto {
	public class m_pet_enter_toc : Message
	{
		public object[] pets;
		public m_pet_enter_toc() {
		}
		public override string getMethodName() {
			return "pet_enter";
		}
		public override string getClassName() {
			return "m_pet_enter_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pets", "array", "p_map_pet"}};
		}
	}
}
