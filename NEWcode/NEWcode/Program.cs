using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace DZ
{

	[Serializable]
	class WORD
	{
		string word;
		List<string> translation;
		public WORD(string word)
		{
			this.word = word;
			translation = new List<string>();
		}
		public string Word
		{
			set { word = value; }
			get { return word; }
		}
		public List<string> Translation
		{
			set { translation = value; }
			get { return translation; }
		}
        public void PrintInfo()
        {
			Console.Write(word + "=>>");
			for(int i=0;i< translation.Count;i++)
            {
				if (i < translation.Count - 1)
					Console.Write(translation[i] + "; ");
				else
					Console.WriteLine(translation[i]);
            }
        }
    }
	[Serializable]
	class Dictionary
    {
		string type;
		List<WORD> words;
		public string Type
        {
            get { return type; }
        }
		public Dictionary(string type)
        {
			this.type = type;
			words = new List<WORD>();
		}
		public void AddWord(WORD word)
        {
			words.Add(word);

		}
		public void AddTranslation(string name)
        {
			int index = -1;
			for(int i=0;i<words.Count;i++)
            {
				if(string.Compare(name,words[i].Word)==0)
                {
					index = i;
					break;
                }
            }
			if (index != -1)
			{

				Console.Write("Введіть переклад, який хочете додати->");
				string new_translation = Console.ReadLine();
				Console.Clear();
				words[index].Translation.Add(new_translation);
				Console.WriteLine("Додано!");
				Console.WriteLine("Додати ще один переклад->1\nВихід->0");
				Console.Write("->");
				int k = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				while (k != 0)
				{
					Console.Write("Введіть переклад, який хочете додати->");
					new_translation = Console.ReadLine();
					Console.Clear();
					words[index].Translation.Add(new_translation);
					Console.WriteLine("Додано!");
					Console.WriteLine("Додати ще один переклад->1\nВихід->0");
					Console.Write("->");
					k = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
				}
			}
			else
				Console.WriteLine("Не знайдено!");
        }
		public void RedactWord(string name)
        {
			int index = -1;
			for (int i = 0; i < words.Count; i++)
			{
				if (string.Compare(name, words[i].Word) == 0)
				{
					index = i;
					break;
				}
			}
			if (index != -1)
			{

				Console.Write("Введіть назву слова, на яке хочете змінити->");
				string new_word = Console.ReadLine();
				Console.Clear();
				words[index].Word = new_word;
				Console.WriteLine("Змінено!");
			}
			else
				Console.WriteLine("Не знайдено!");
		}
		public void RedactTranslation(string name,string old_translation)
		{
			int index = -1;
			for (int i = 0; i < words.Count; i++)
			{
				if (string.Compare(name, words[i].Word) == 0)
				{
					index = i;
					break;
				}
			}
			if (index != -1)
			{
				int index2 = -1;
				for(int i=0;i< words[index].Translation.Count;i++)
                {
					if(string.Compare(old_translation, words[index].Translation[i])==0)
                    {
						index2 = i;
						break;
                    }
                }
				if(index2!=-1)
                {
					Console.Write("Введіть переклад, на який хочете змінити->");
					string new_translation = Console.ReadLine();
					Console.Clear();
					words[index].Translation[index2] = new_translation;
					Console.WriteLine("Змінено!");
				}
				else
					Console.WriteLine("Не знайдено!");
			}
			else
				Console.WriteLine("Не знайдено!");
		}
		public void DeleteWord(string name)
        {
			int index = -1;
			for (int i = 0; i < words.Count; i++)
			{
				if (string.Compare(name, words[i].Word) == 0)
				{
					index = i;
					break;
				}
			}
			if (index != -1)
			{

				words.RemoveAt(index);
				Console.WriteLine("Видалено!");
			}
			else
				Console.WriteLine("Не знайдено!");
		}
		public void DeleteTranslation(string name, string old_translation)
		{
			int index = -1;
			for (int i = 0; i < words.Count; i++)
			{
				if (string.Compare(name, words[i].Word) == 0)
				{
					index = i;
					break;
				}
			}
			if (index != -1)
			{
				int index2 = -1;
				for (int i = 0; i < words[index].Translation.Count; i++)
				{
					if (string.Compare(old_translation, words[index].Translation[i]) == 0)
					{
						index2 = i;
						break;
					}
				}
				if (index2 != -1)
				{
					if (words[index].Translation.Count > 1)
					{
						words[index].Translation.RemoveAt(index2);
						Console.WriteLine("Видалено!");
					}
					else
						Console.WriteLine("Видалення неможливе оскільки це єдиний переклад");
				}
				else
					Console.WriteLine("Не знайдено!");
			}
			else
				Console.WriteLine("Не знайдено!");
		}
		public void SearchTranslation(string name)
        {
			int index = -1;
			for (int i = 0; i < words.Count; i++)
			{
				if (string.Compare(name, words[i].Word) == 0)
				{
					index = i;
					break;
				}
			}
			if (index != -1)
			{
				words[index].PrintInfo();
				Console.WriteLine("Зберегти у файл Мої_шукані_слова?\nТак->1\nНі->2");
				int k = Convert.ToInt32(Console.ReadLine());
				if(k==1)
                {
					FileStream fs = new FileStream("Мої_шукані_слова.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
					StreamWriter streamWriter = new StreamWriter(fs, Encoding.UTF8);
					string txt = words[index].Word + "=>>";
					for (int i = 0; i < words[index].Translation.Count; i++)
					{
						if (i < words[index].Translation.Count - 1)
							txt+=words[index].Translation[i] + "; ";
						else
							txt += words[index].Translation[i];
					}
					streamWriter.WriteLine(txt);
					streamWriter.Dispose();
					fs.Close();
					Console.WriteLine("Збережено!");
                }
			}
			else
				Console.WriteLine("Не знайдено!");
		}
		public void PrintInfo()
        {
			Console.WriteLine(type);
			Console.WriteLine("------------------------------------------------------");
			for(int i=0;i<words.Count;i++)
            {
				words[i].PrintInfo();
				Console.WriteLine("------------------------------------------------------");
			}
        }
		
	}
	[Serializable]
	class Dictionaries
	{
		List<Dictionary> dictionaries;
		public List<Dictionary> DICTIONARies
		{
			set { dictionaries = value; }
			get { return dictionaries; }
		}
		public Dictionaries()
		{
			dictionaries = new List<Dictionary>();
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			System.Console.OutputEncoding = System.Text.Encoding.UTF8;

			try
			{
				FileStream fs;
				BinaryFormatter bf = new BinaryFormatter();
				string type;
				Dictionaries dictionaries = new Dictionaries();
				Console.WriteLine("Додати словник->1\nЗчитати словники->3\nВихід->0");
				Console.Write("->");
				int k = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				while (k != 0)
				{
					switch (k)
					{
						case 1:
							Console.Write("Введіть тип словника(наприклад україно-англійський)->");
							type = Console.ReadLine();
							Console.Clear();
							dictionaries.DICTIONARies.Add(new Dictionary(type));
							Console.WriteLine("Додано!");
							break;
						case 2:
							if (dictionaries.DICTIONARies.Count > 0)
							{
								Console.WriteLine("Оберіть словника:");
								for (int i = 0; i < dictionaries.DICTIONARies.Count; i++)
								{
									Console.WriteLine(dictionaries.DICTIONARies[i].Type + "->" + (i + 1));
								}
								Console.Write("->");
								int j = Convert.ToInt32(Console.ReadLine());
								Console.Clear();
								if (j - 1 >= 0 & j - 1 < dictionaries.DICTIONARies.Count)
								{
									Console.WriteLine("Додати слово->1\nВидалити слово->2\nЗнайти слово->3\nЗмінити переклад->4\nЗмінити саме слово->5\nВидалити переклад->6\nПоказати весь словник->7\nВихід->0");
									Console.Write("->");
									int k2 = Convert.ToInt32(Console.ReadLine());
									Console.Clear();
									while (k2 != 0)
									{
										switch (k2)
										{
											case 1:
												Console.Write("Введіть назву слова->");
												string name = Console.ReadLine();
												Console.Clear();
												WORD word = new WORD(name);
												Console.Write("Введіть переклад->");
												string translation = Console.ReadLine();
												Console.Clear();
												word.Translation.Add(translation);
												Console.WriteLine("Додати ще переклад?Так->1Ні->2");
												Console.Write("->");
												int k3 = Convert.ToInt32(Console.ReadLine());
												Console.Clear();
												while (k3 == 1)
												{
													Console.Write("Введіть переклад->");
													translation = Console.ReadLine();
													word.Translation.Add(translation);
													Console.WriteLine("Додати ще переклад?Так->1Ні->2");
													Console.Write("->");
													k3 = Convert.ToInt32(Console.ReadLine());
													Console.Clear();
												}
												dictionaries.DICTIONARies[j - 1].AddWord(word);
												break;
											case 2:
												Console.Write("Введіть назву слова->");
												name = Console.ReadLine();
												Console.Clear();
												dictionaries.DICTIONARies[j - 1].DeleteWord(name);
												break;
											case 3:
												Console.Write("Введіть назву слова->");
												name = Console.ReadLine();
												Console.Clear();
												dictionaries.DICTIONARies[j - 1].SearchTranslation(name);
												break;
											case 4:
												Console.Write("Введіть назву слова->");
												name = Console.ReadLine();
												Console.Clear();
												Console.Write("Введіть назву перекладу який змінити->");
												translation = Console.ReadLine();
												Console.Clear();
												dictionaries.DICTIONARies[j - 1].RedactTranslation(name, translation);
												break;
                                            case 5:
												Console.Write("Введіть назву слова->");
												name = Console.ReadLine();
												Console.Clear();
												dictionaries.DICTIONARies[j - 1].RedactWord(name);
												break;
                                            case 6:
												Console.Write("Введіть назву слова->");
												name = Console.ReadLine();
												Console.Clear();
												Console.Write("Введіть назву перекладу, який видалити->");
												translation = Console.ReadLine();
												Console.Clear();
												dictionaries.DICTIONARies[j - 1].DeleteTranslation(name, translation);
												break;
                                            case 7:
												dictionaries.DICTIONARies[j - 1].PrintInfo();
												break;
                                        }
										Console.WriteLine("Додати слово->1\nВидалити слово->2\nЗнайти слово->3\nЗмінити переклад->4\nЗмінити саме слово->5\nВидалити переклад->6\nПоказати весь словник->7\nВихід->0");
										Console.Write("->");
										k2 = Convert.ToInt32(Console.ReadLine());
										Console.Clear();
									}
								}
								else
									Console.WriteLine("Не коректно!");
							}
							break;
						case 3:
							fs = new FileStream("Dictionaries.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
							dictionaries = (Dictionaries)bf.Deserialize(fs);
							fs.Close();
							Console.WriteLine("Зчитано!");
							break;
						case 4:
							fs = new FileStream("Dictionaries.txt", FileMode.Create, FileAccess.Write, FileShare.Write);

							bf.Serialize(fs, dictionaries);
							fs.Close();
							Console.WriteLine("Збережено!");
							break;
							
					}
					Console.WriteLine("Додати словник->1\nУвійти в словник->2\nЗчитати словники->3\nЗберегти словники->4\nВихід->0");
					Console.Write("->");
					k = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
				}
			}
			catch(Exception e)
            {
				Console.WriteLine(e.Message);
            }
		}
    }
}