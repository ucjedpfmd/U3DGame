namespace proto {
	public class m_couple_depot_update_toc : Message
	{
		public object[] update;
		public object[] del;
		public m_couple_depot_update_toc() {
		}
		public override string getMethodName() {
			return "couple_depot_update";
		}
		public override string getClassName() {
			return "m_couple_depot_update_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"update", "array", "p_couple_goods"},new string[] {"del", "array", "p_couple_goods"}};
		}
	}
}
