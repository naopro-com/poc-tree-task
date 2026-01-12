namespace TreeTask.Data
{
    using TreeTask.Models;

    public static class SampleOrganizationData
    {
        public static Tree GetSampleOrganization()
        {
            return new Tree
            {
                Id = "CEO-001",
                Description = "Sophie Marchand - PDG - Direction Générale",
                Children = new[]
                {
                    new Tree
                    {
                        Id = "CTO-001",
                        Description = "Marc Dubois - CTO - Technologies & Innovation",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "LEAD-FRONT-001",
                                Description = "Amélie Laurent - Lead Frontend - React & Blazor",
                                Children = new[]
                                {
                                    new Tree
                                    {
                                        Id = "DEV-FRONT-001",
                                        Description = "Thomas Roux - Dev Frontend - UI/UX Components"
                                    },
                                    new Tree
                                    {
                                        Id = "DEV-FRONT-002",
                                        Description = "Julie Martin - Dev Frontend - Accessibilité & Performance"
                                    }
                                }
                            },
                            new Tree
                            {
                                Id = "LEAD-BACK-001",
                                Description = "Pierre Lefevre - Lead Backend - Architecture & APIs",
                                Children = new[]
                                {
                                    new Tree
                                    {
                                        Id = "DEV-BACK-001",
                                        Description = "Nicolas Petit - Dev Backend - .NET Core & Azure"
                                    },
                                    new Tree
                                    {
                                        Id = "DEV-BACK-002",
                                        Description = "Sarah Bernard - Dev Backend - Microservices & Databases"
                                    }
                                }
                            },
                            new Tree
                            {
                                Id = "LEAD-DEVOPS-001",
                                Description = "Léa Moreau - Responsable DevOps - CI/CD & Cloud",
                                Children = new[]
                                {
                                    new Tree
                                    {
                                        Id = "ENG-DEVOPS-001",
                                        Description = "Antoine Garnier - Ingénieur DevOps - Kubernetes & Terraform"
                                    }
                                }
                            }
                        }
                    },
                    new Tree
                    {
                        Id = "CFO-001",
                        Description = "Catherine Durand - Directrice Financière - Gestion & Contrôle",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "COMPTA-001",
                                Description = "François Simon - Responsable Comptabilité - Comptabilité Générale"
                            },
                            new Tree
                            {
                                Id = "CONTROLE-001",
                                Description = "Isabelle Michel - Contrôleuse de Gestion - Analyse & Reporting"
                            }
                        }
                    },
                    new Tree
                    {
                        Id = "CMO-001",
                        Description = "Alexandre Blanc - Directeur Marketing - Stratégie & Communication",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "PROD-001",
                                Description = "Emma Rousseau - Chef de Produit - Produits Digitaux",
                                Children = new[]
                                {
                                    new Tree
                                    {
                                        Id = "PO-001",
                                        Description = "Hugo Lemoine - Product Owner - Features & Roadmap"
                                    }
                                }
                            },
                            new Tree
                            {
                                Id = "COM-001",
                                Description = "Camille Girard - Resp. Communication - Communication Digitale"
                            },
                            new Tree
                            {
                                Id = "UX-001",
                                Description = "Lucas André - UX Designer - Expérience Utilisateur"
                            }
                        }
                    },
                    new Tree
                    {
                        Id = "HR-001",
                        Description = "Nathalie Fontaine - DRH - Ressources Humaines & Talents",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "RECRUTEMENT-001",
                                Description = "Olivier Chevalier - Resp. Recrutement - Acquisition de Talents"
                            },
                            new Tree
                            {
                                Id = "FORMATION-001",
                                Description = "Marie Gauthier - Resp. Formation - Développement des Compétences"
                            }
                        }
                    }
                }
            };
        }

        public static Tree GetStartupOrganization()
        {
            return new Tree
            {
                Id = "FOUNDER-001",
                Description = "Jean Dupont - CEO & Fondateur - Vision & Stratégie",
                Children = new[]
                {
                    new Tree
                    {
                        Id = "TECH-001",
                        Description = "Claire Martin - Lead Developer - Full Stack Development"
                    },
                    new Tree
                    {
                        Id = "PRODUCT-001",
                        Description = "Paul Durand - Chef de Produit - Product Management & UX"
                    },
                    new Tree
                    {
                        Id = "SALES-001",
                        Description = "Marie Blanc - Responsable Commercial - Ventes & Partenariats"
                    }
                }
            };
        }

        public static Tree GetITDepartmentOrganization()
        {
            return new Tree
            {
                Id = "IT-DIR-001",
                Description = "Vincent Rousseau - Directeur IT - Infrastructure & Sécurité",
                Children = new[]
                {
                    new Tree
                    {
                        Id = "DEV-TEAM-001",
                        Description = "🔧 Équipe Développement",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "DEV-001",
                                Description = "Alice Dubois - Senior Developer - Architecture"
                            },
                            new Tree
                            {
                                Id = "DEV-002",
                                Description = "Bob Martin - Developer - Backend APIs"
                            },
                            new Tree
                            {
                                Id = "DEV-003",
                                Description = "Chloé Petit - Developer - Frontend Web"
                            }
                        }
                    },
                    new Tree
                    {
                        Id = "INFRA-TEAM-001",
                        Description = "🖥️ Équipe Infrastructure",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "SYSADMIN-001",
                                Description = "David Leroy - Admin Système - Serveurs & Réseaux"
                            },
                            new Tree
                            {
                                Id = "SECURITY-001",
                                Description = "Élodie Moreau - Resp. Sécurité - Cybersécurité & Conformité"
                            }
                        }
                    },
                    new Tree
                    {
                        Id = "SUPPORT-TEAM-001",
                        Description = "📞 Équipe Support",
                        Children = new[]
                        {
                            new Tree
                            {
                                Id = "SUPPORT-001",
                                Description = "Fabien Roux - Support N2 - Incidents & Problèmes"
                            },
                            new Tree
                            {
                                Id = "SUPPORT-002",
                                Description = "Gabrielle Simon - Support N1 - Assistance Utilisateurs"
                            }
                        }
                    }
                }
            };
        }

        public static Tree GetMinimalOrganization()
        {
            return new Tree
            {
                Id = "BOSS-001",
                Description = "🎯 Pierre Directeur - CEO",
                Children = new[]
                {
                    new Tree
                    {
                        Id = "TEAM-A",
                        Description = "👨‍💻 Équipe Technique",
                        Children = new[]
                        {
                            new Tree { Id = "DEV-A1", Description = "Sophie - Développeuse" },
                            new Tree { Id = "DEV-A2", Description = "Marc - Développeur" }
                        }
                    },
                    new Tree
                    {
                        Id = "TEAM-B",
                        Description = "📊 Équipe Business",
                        Children = new[]
                        {
                            new Tree { Id = "BUS-B1", Description = "Julie - Commerciale" },
                            new Tree { Id = "BUS-B2", Description = "Luc - Marketing" }
                        }
                    }
                }
            };
        }
    }
}