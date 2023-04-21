using System;
using System.Linq;

namespace Custom_Furniture
{
	// Token: 0x02000006 RID: 6
	internal class SelectiveFurniture : KMonoBehaviour
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002474 File Offset: 0x00000674
		protected override void OnCleanUp()
		{
			base.Unsubscribe(493375141);
			base.OnCleanUp();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000248A File Offset: 0x0000068A
		protected override void OnPrefabInit()
		{
			base.OnPrefabInit();
			base.Subscribe(493375141, new Action<object>(this.OnRefreshUserMenu));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024AC File Offset: 0x000006AC
		private void OnNextArtClicked()
		{
			int num = this.artable.stages.FindIndex((Artable.Stage s) => s.id == this.artable.CurrentStage);
			Artable.Stage stage = ((num + 1 == this.artable.stages.Count) ? this.artable.stages[0] : this.artable.stages[num + 1]);
			this.artable.SetStage(stage.id, false);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002528 File Offset: 0x00000728
		private void OnBackArtClicked()
		{
			int num = this.artable.stages.FindIndex((Artable.Stage s) => s.id == this.artable.CurrentStage);
			Artable.Stage stage = ((num == 0) ? this.artable.stages[this.artable.stages.Count - 1] : this.artable.stages[num - 1]);
			this.artable.SetStage(stage.id, false);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000025A4 File Offset: 0x000007A4
		private void OnRefreshUserMenu(object obj)
		{
			bool flag = !(this.artable != null);
			if (!flag)
			{
				string text = "action_direction_right";
				string text2 = "action_direction_left";
				Artable.Status status = this.artable.stages.Find((Artable.Stage s) => s.id == this.artable.CurrentStage).statusItem;
				int count = this.artable.stages.Where((Artable.Stage s) => s.statusItem == status).ToList<Artable.Stage>().Count;
				bool flag2 = count > 1;
				if (flag2)
				{
					Game instance = Game.Instance;
					if (instance != null)
					{
						UserMenu userMenu = instance.userMenu;
						if (userMenu != null)
						{
							userMenu.AddButton(base.gameObject, new KIconButtonMenu.ButtonInfo(text, INTERNALSTRINGS.NEXT_MODEL_BUTTON.TEXT, new Action(this.OnNextArtClicked), 98, null, null, null, INTERNALSTRINGS.NEXT_MODEL_BUTTON.TOOLTIP, true), 1f);
						}
					}
				}
				bool flag3 = count > 1;
				if (flag3)
				{
					Game instance2 = Game.Instance;
					if (instance2 != null)
					{
						UserMenu userMenu2 = instance2.userMenu;
						if (userMenu2 != null)
						{
							userMenu2.AddButton(base.gameObject, new KIconButtonMenu.ButtonInfo(text2, INTERNALSTRINGS.BACK_MODEL_BUTTON.TEXT, new Action(this.OnBackArtClicked), 99, null, null, null, INTERNALSTRINGS.BACK_MODEL_BUTTON.TOOLTIP, true), 1f);
						}
					}
				}
			}
		}

		// Token: 0x04000003 RID: 3
		public Artable artable;
	}
}
