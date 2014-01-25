namespace proto {
	public class m_pet_attr_change_toc : Message
	{
		public double pet_id = 0;
		public object[] changes;
		public m_pet_attr_change_toc() {
		}
		public override string getMethodName() {
			return "pet_attr_change";
		}
		public override string getClassName() {
			return "m_pet_attr_change_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"changes", "array", "p_key_value"}};
		}
	}
}
